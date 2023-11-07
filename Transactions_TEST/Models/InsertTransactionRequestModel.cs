namespace Transactions_TEST.Models
{
    public class InsertTransactionRequestModel
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string CardholderNumber { get; set; }
        public string HolderName { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int CVV { get; set; }
        public string OrderRef { get; set; }
    }
}
