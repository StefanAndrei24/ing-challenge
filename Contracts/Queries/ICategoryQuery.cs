using Bank.Models.Queries;

namespace Bank.Contracts.Queries
{
    public interface ICategoryQuery
    {
        Task<List<CategoryQueryResponse>> GetCategoriesAsync();
    }
}
