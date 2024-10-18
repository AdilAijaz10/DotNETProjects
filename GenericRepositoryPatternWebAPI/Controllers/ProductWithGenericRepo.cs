using GenericRepositoryPatternWebAPI.Model;
using GenericRepositoryPatternWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace GenericRepositoryPatternWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductWithGenericRepo : ControllerBase
    {
        private readonly IRepository<Product> _productRepository;

        public ProductWithGenericRepo(IRepository<Product> ProductRepository)
        {
            _productRepository = ProductRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductRequest product)
        {
            var productEntity = new Product()
            {
                ProductName = product.ProductName,
                Price = product.Price,
            };
            var CreateProductResponse = await _productRepository.AddAsync(productEntity);
            return CreatedAtAction(nameof(GetById), new { id = CreateProductResponse.ProductId });

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProductRequest product)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            if (productEntity == null)
            {
                return NotFound();
            }
            productEntity.ProductName = product.ProductName;
            productEntity.Price = product.Price;
            await _productRepository.UpdateAsync(productEntity);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Product = await _productRepository.GetByIdAsync(id);
            if(Product == null)
            {
                return NotFound();
            }
            await _productRepository.DeleteAsync(Product);
            return NoContent();
        }
    }
}
