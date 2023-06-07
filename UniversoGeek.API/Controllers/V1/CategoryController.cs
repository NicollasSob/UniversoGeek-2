using Microsoft.AspNetCore.Mvc;
using UniversoGeek.Application.Interfaces;
using UniversoGeek.Application.ViewModel;

namespace UniversoGeek.API.Controllers.V1
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _CategoryAppService;

        public CategoryController(ICategoryAppService CategoryAppService)
        {
            _CategoryAppService = CategoryAppService;
        }

        [HttpGet]
        // Traz todos os produtos cadastrados no sistema
        public async Task<ActionResult> Get()
        {
            var result = await _CategoryAppService.SearchAsync(a => true);

            return Ok(result);
        }

        [HttpGet("{id}")]
        // Traz um Produto de acordo com o seu ID
        public async Task<ActionResult<CategoryViewModel>> Get(Guid id)
        {
            var result = await _CategoryAppService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        //Insere um produto no banco de dados
        public async Task<ActionResult> PostAsync([FromBody] CategoryViewModel model)
        {
            var result = await _CategoryAppService.AddAsync(model);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] CategoryViewModel model)
        {
            return Ok(_CategoryAppService.Update(model));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _CategoryAppService.Remove(id);
            return Ok();
        }
    }

}