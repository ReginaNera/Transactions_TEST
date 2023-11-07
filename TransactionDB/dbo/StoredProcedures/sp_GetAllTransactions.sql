CREATE PROCEDURE [dbo].[sp_GetAllTransactions]
AS
begin
	SELECT * from dbo.[Transactions] where Status = 2;
end;