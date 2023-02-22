namespace Bank.Models.Queries
{
    public class TransactionReportQueryResponse
    {
        public string CategoryName { get; set; }

        public double totalAmount { get; set; }

        public string Currency { get; set; }
    }
}
