using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/categories")]
    public class CategoriesController(ICategoryService categoryService) : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {           
            var categories = await categoryService.GetAll();          
            return Ok(categories);
        }

        [HttpGet("{categoryId:long}")]
        public async Task<IActionResult> GetById(long categoryId) 
        {        
            var category = await categoryService.GetById(categoryId);     
            return Ok(category);
        }
    }
}
