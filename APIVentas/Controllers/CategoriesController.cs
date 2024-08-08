using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return new List<Category> { new Category { Id = 1, Description = "Tecnología" } };
        }
    }
}
