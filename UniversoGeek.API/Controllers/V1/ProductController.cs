﻿using Microsoft.AspNetCore.Mvc;
using UniversoGeek.Application.Interfaces;
using UniversoGeek.Application.ViewModel;

namespace UniversoGeek.API.Controllers.V1
{
    [ApiController]
    [Route("api/v1/product")]
    public class ProductController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        // Traz todos os produtos cadastrados no sistema
        public async Task<ActionResult> Get()
        {
            var result = await _productAppService.SearchAsync(a => true);

            return Ok(result);
        }

        [HttpGet("{id}")]
        // Traz um Produto de acordo com o seu ID
        public async Task<ActionResult<ProductViewModel>> Get(Guid id)
        {
            var result = await _productAppService.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpGet("productbycategory/{category}")]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> GetProductCategory(Guid category)
        {
            var result = await _productAppService.SearchAsync(c  => c.CategoryId == category);
            return Ok(result);
        }

        [HttpPost]
        //Insere um produto no banco de dados
        public async Task<ActionResult> PostAsync([FromBody] ProductViewModel model)
        {
            var result = await _productAppService.AddAsync(model);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] ProductViewModel model)
        {
            return Ok(_productAppService.Update(model));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _productAppService.Remove(id);
            return Ok();
        }

        [HttpPost("decreaseStock/{productId}/{quantity}")]
        public ActionResult SetDecreaseStock(Guid productId, int quantity)
        {
            try
            {
                _productAppService.DecreaseStock(productId, quantity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
