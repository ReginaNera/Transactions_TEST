namespace Transactions_TEST.Models
{
    public class TransactionResponseModel
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string CardholderNumber { get; set; }
        public string HolderName { get; set; }
        public string Status { get; set; }
 
    }
}
