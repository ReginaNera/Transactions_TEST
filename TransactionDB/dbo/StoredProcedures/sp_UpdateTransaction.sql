CREATE PROCEDURE [dbo].[sp_UpdateTransaction]
	@Id uniqueIdentifier,
	@Status int,
	@OrderRef NVARCHAR(50)
AS
begin
 UPDATE dbo.[Transactions] set Status = @Status,OrderRef = @OrderRef  where Id = @Id;
end;
