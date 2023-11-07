CREATE PROCEDURE [dbo].[sp_InsertTransaction]
    @Id uniqueIdentifier,
	@Amount decimal,
	@Currency nvarchar(3),
    @CardholderNumber nvarchar(16),
	@HolderName nvarchar(30),
	@ExpMonth int,
	@ExpYear int,
	@CVV int,
	@OrderRef nvarchar(50),
	@Status int
AS
	begin
	insert into dbo.[Transactions] (Id,Amount,Currency, CardholderNumber, HolderName, ExpMonth, ExpYear, CVV, OrderRef, Status)
				VALUES(@Id,@Amount,@Currency, @CardholderNumber, @HolderName, @ExpMonth, @ExpYear,@CVV, @OrderRef, @Status);
	end;
