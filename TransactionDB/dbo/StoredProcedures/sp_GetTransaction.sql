CREATE PROCEDURE [dbo].[sp_GetTransaction]
	@Id uniqueIdentifier
AS
begin
		SELECT * from dbo.[Transactions]
		where Id = @Id;
end;