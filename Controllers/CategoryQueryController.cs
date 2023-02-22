using Bank.Contracts.Commands;
using Bank.Contracts.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [ApiController]
    public class CategoryQueryController : ControllerBase
    {
        public CategoryQueryController(ICategoryQuery categoryQuery, ICategoryCommander categoryCommander)
        {
            CategoryQuery = categoryQuery;
            CategoryCommander = categoryCommander;
        }

        private ICategoryQuery CategoryQuery { get; }
        
        private ICategoryCommander CategoryCommander { get; }

        [HttpGet("categories")]
        public async Task<IActionResult> GetCategoriesAsync() =>
            Ok(await CategoryQuery.GetCategoriesAsync());

        [HttpPost("category")]
        public async Task<IActionResult> AddNewCategoryAsync([FromQuery] string category) =>
            Ok(await CategoryCommander.AddCategoryAsync(category));
    }
}
