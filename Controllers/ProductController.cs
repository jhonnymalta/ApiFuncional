using ApiFuncional.Data;
using ApiFuncional.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncional.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public ProductController(ApiDbContext context)
        {
            _context = context;
        }

        

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<Product> GetProducts(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product) {
            _context.Products.AddAsync(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutProduct(int id, Product product) {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return NoContent();
            
        }
        [HttpDelete("{id:inf}")]
        public async Task<ActionResult> DeleteProduct(int id){ 
            var produto = await _context.Products.FindAsync(id);
            _context.Products.Remove(produto);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
