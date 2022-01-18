using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ProductsController : DefaultsApiController
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() => await _context.Products.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            var productExist = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if(productExist == null)
                return NotFound("Product does not exist.");

            return productExist;
        }
    }
}