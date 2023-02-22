namespace Bank.Contracts.Commands
{
    public interface ICategoryCommander
    {
        Task<bool> AddCategoryAsync(string categoryName);
    }
}
