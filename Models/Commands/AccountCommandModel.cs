namespace Bank.Models.Commands
{
    public class AccountCommandModel
    {
        public Guid ResourceId { get; set; }

        public string Product { get; set; }

        public string Iban { get; set; }

        public string Name { get; set; }

        public string Currency { get; set; }

        public long ClientId { get; set; }
    }
}
