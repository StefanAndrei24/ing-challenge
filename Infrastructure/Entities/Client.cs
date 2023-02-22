namespace Bank.Infrastructure.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
