using DF_NTCong_Repo_Core.Models;
using DF_NTCong_Repo_Core.Models.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DF_NTCong_Repo_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_TableController : ControllerBase
    {
        //private readonly DataContext _context;
        private IProductRepository _productRepository;

        public Product_TableController(DataContext context)
        {
            //_context = context;
            _productRepository = new ProductRepository(context);
        }

        // GET: api/Product_Table
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_Table>>> GetProduct_Table()
        {
            //if (_context.Product_Table == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Product_Table.ToListAsync();

            return _productRepository.GetProducts().ToList();
        }

        // GET: api/Product_Table/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_Table>> GetProduct_Table(int id)
        {
            if (_productRepository.GetProducts() == null)
            {
                return NotFound();
            }
            var product_Table = _productRepository.GetProductById(id);

            if (product_Table == null)
            {
                return NotFound();
            }

            return _productRepository.GetProductById(id);
        }

        // PUT: api/Product_Table/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Table(int id, Product_Table product_Table)
        {
            if (id != product_Table.Id)
            {
                return BadRequest();
            }

            //_context.Entry(product_Table).State = EntityState.Modified;
            _productRepository.UpdateProduct(product_Table);
            try
            {
                //await _context.SaveChangesAsync();
                _productRepository.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_TableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Product_Table
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_Table>> PostProduct_Table(Product_Table product_Table)
        {
            if (_productRepository.GetProducts() == null)
            {
                return Problem("Entity set 'DataContext.Product_Table'  is null.");
            }
            _productRepository.InsertProduct(product_Table);
            try
            {
                _productRepository.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Product_TableExists(product_Table.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduct_Table", new { id = product_Table.Id }, product_Table);
        }

        // DELETE: api/Product_Table/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_Table(int id)
        {
            if (_productRepository.GetProducts() == null)
            {
                return NotFound();
            }
            var product_Table = _productRepository.GetProductById(id);
            if (product_Table == null)
            {
                return NotFound();
            }

            _productRepository.DeleteProduct(id);
            _productRepository.SaveChanges();

            return NoContent();
        }

        private bool Product_TableExists(int id)
        {
            return (_productRepository.GetProducts()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
