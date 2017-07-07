param(

           # Getting the control percentage as an argument

           [int] $desiredCodeCoveragePercent 

)
Write-Host “Desired Code Coverage Percent is “ -nonewline; Write-Host $desiredCodeCoveragePercent


# Load Assemblies we use. Make sure you change the version as per need. 

[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.Client”)  
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.TestManagement.Client”) 
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.TestManagement.Common”) 
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.Build.Client”) 
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.VersionControl.Client”) 
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.VersionControl.Common”) 
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.WorkItemTracking.Client”) 
[Reflection.Assembly]::LoadWithPartialName(“Microsoft.TeamFoundation.Build.Common”)

 
# Getting a few Global variables we need

$CollectionUrl = "http://USDFW13WS26V:8080/tfs/TFSQA"
[String] $BuildUrl = “$env:BUILD_BUILDURI“
$project = "RMPOC_SCRUM"





try
{
 $uri = New-Object System.Uri -ArgumentList $CollectionUrl
    $credentialProvider = new-object Microsoft.TeamFoundation.Client.UICredentialsProvider
    $collection = [Microsoft.TeamFoundation.Client.TfsTeamProjectCollectionFactory]::GetTeamProjectCollection($uri, $credentialProvider)
    $collection.Authenticate()
    if ($collection.HasAuthenticated)
    {
        Write-Host -ForegroundColor Green 'Connection to TFS Successful'
        $tcmService = $collection.GetService([Microsoft.TeamFoundation.TestManagement.Client.ITestManagementService])
       $buildServer = $collection.GetService([Microsoft.TeamFoundation.Build.Client.IBuildServer])
       [Microsoft.TeamFoundation.TestManagement.Client.ITestManagementTeamProject] $tcmProject = $tcmService.GetTeamProject($project);

       # Getting all the test run as part of the build 
       $totalRuns = $tcmProject.TestRuns.ByBuild($BuildUrl)
       

      # Getting Code coverage class details
      [Microsoft.TeamFoundation.TestManagement.Client.ICoverageAnalysisManager] $coverageAnalysisManager = $tcmProject.CoverageAnalysisManager
      # Looping through all the results

 foreach ($currentRun in $totalRuns)
 {

            $sourceBlocks = $coverageAnalysisManager.QueryTestRunCoverage($currentRun.Id, 1)
         foreach ($currentBlock in $sourceBlocks)

           {

                       $modules = $currentBlock.Modules

                       foreach($module in $modules)

                      {

                                            $coveredBlocks += $module.Statistics.BlocksCovered

                                            $skippedBlocks += $module.Statistics.BlocksNotCovered  

                      }

           }

}

 

 $totalBlocks = $coveredBlocks + $skippedBlocks;
  
 if ($totalBlocks -eq 0)

{

           $codeCoveragePercent = 0

           Write-Host $codeCoveragePercent -nonewline; Write-Host ” is the Code Coverage. Failing the build”

           exit -1

 

}

 $codeCoveragePercent = $coveredBlocks * 100.0 / $totalBlocks

Write-Host “Code Coverage percentage is “ -nonewline; Write-Host $codeCoveragePercent


if ($codeCoveragePercent -le $desiredCodeCoveragePercent)

{

           Write-Host “Failing the build as CodeCoverage limit not met”

           exit -1

}

Write-Host “CodeCoverage limit met”
#GetService

        }
        }
catch
{
    Write-Host -ForegroundColor Red $_.Exception.Message
    Write-Host
    Write-Host -ForegroundColor Red 'Failed to connect to TFS'
}