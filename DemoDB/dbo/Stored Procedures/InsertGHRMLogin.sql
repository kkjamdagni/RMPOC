CREATE PROCEDURE dbo.InsertGHRMLogin
	@UserName	varchar(50),
	@EMail		varchar(255),
	@LogoutURL	varchar(255),
	@UID		varchar(255) out
AS

SET NOCOUNT ON
DECLARE @Row	int
DECLARE @Error	int

SET @Error = 0
SET @Row = 0

BEGIN TRAN

INSERT GHRM
(	UserName,
	EMail,
	LogoutURL)
VALUES
(	@UserName,
	@EMail,
	@LogoutURL)

IF (@@ERROR <> 0)
    SET @Error = @@ERROR

SET @Row = @@IDENTITY

IF @Error <> 0 
    ROLLBACK TRAN
Else
    BEGIN
        COMMIT TRAN
        SELECT @UID = Convert(varchar(255),  UniqueID) FROM GHRM WHERE [ID] = @Row
    END

SET NOCOUNT OFF
Return @Error