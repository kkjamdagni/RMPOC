$xmldata = [XML](Get-Content "TestResults\emma\coverage.xml")
[STRING]$percent_method = $xmldata.report.data.all.coverage[1].value
[int]$percent_method = $percent_method.Substring(0,2)
if ($percent_method -le 70)
{
echo Method coverage is less than 70 Percent. Failing the build.
EXIT 1
}
else 
{
echo Method coverage is more than 70 Percent. Passing the build.
EXIT 0
}