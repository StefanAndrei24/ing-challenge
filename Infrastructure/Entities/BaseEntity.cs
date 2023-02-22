namespace Bank.Infrastructure.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public DateTime InsertedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
