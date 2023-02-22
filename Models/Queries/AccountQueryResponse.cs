namespace Bank.Models.Queries
{
    public class AccountQueryResponse
    {
        public Guid ResourceId { get; set; }

        public string Product { get; set; }

        public string Iban { get; set; }

        public string Name { get; set; }

        public string Currency { get; set; }
    }
}
