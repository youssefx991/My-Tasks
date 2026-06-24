using Dapper.Core.Entities;
using Dapper.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products =
                await _unitOfWork.Products.GetAllAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product =
                await _unitOfWork.Products.GetByIdAsync(id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var id =
                await _unitOfWork.Products.AddAsync(product);

            return Ok(id);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            var result =
                await _unitOfWork.Products.UpdateAsync(product);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result =
                await _unitOfWork.Products.DeleteAsync(id);

            return Ok(result);
        }
    }
}
