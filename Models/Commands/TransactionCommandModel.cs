namespace Bank.Models.Commands
{
    public class TransactionCommandModel
    {
        public string Iban { get; set; }

        public double Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public long CategoryId { get; set; }

        public long AccountId { get; set; }
    }
}
