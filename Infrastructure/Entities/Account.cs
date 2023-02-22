namespace Bank.Infrastructure.Entities
{
    public class Account : BaseEntity
    {
        public Guid ResourceId { get; set; }

        public string Product { get; set; }

        public string Iban { get; set; }

        public string Name { get; set; }

        public string Currency { get; set; }

        public long ClientId { get; set; }

        public Client Client { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
