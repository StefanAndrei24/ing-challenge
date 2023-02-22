namespace Bank.Models.Queries
{
    public class TransactionQueryResponse
    {
        public string Iban { get; set; }

        public long TransactionId { get; set; }

        public double Amount { get; set; }

        public long CategoryId { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
