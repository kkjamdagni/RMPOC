CREATE PROCEDURE dbo.ProcessGHRMLogin
	@UID	varchar(255) 
AS

SET NOCOUNT ON

DECLARE @Row	int
DECLARE @Error	int

SET @Error = 0
SET @Row = 0


--DECLARE @UniqueID		varchar(255)
DECLARE @UserName		varchar(50)
DECLARE @EMail		varchar(255)
DECLARE @LogoutURL		varchar(255)

BEGIN TRAN

SELECT @UID = UniqueID, @UserName = UserName, @EMail = EMail, @LogoutURL = LogoutURL FROM GHRM WHERE Convert(varchar(255), UniqueID) = @UID
SET @Row = @@RowCount
DELETE GHRM WHERE  Convert(varchar(255), UniqueID) = @UID

COMMIT TRAN

IF @Row <> 1
SELECT @UID AS UniqueID, @UserName AS UserName, @EMail AS EMail, @LogoutURL AS LogoutURL  WHERE 1 = 2
ELSE
SELECT @UID AS UniqueID, @UserName AS UserName, @EMail AS EMail, @LogoutURL AS LogoutURL 


SET NOCOUNT OFF
Return