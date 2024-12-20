using Microsoft.AspNetCore.Mvc;
using Skinet.Application.Interfaces;
using Skinet.Application.Specifications;
using Skinet.Entities.Product;

namespace Skinet.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IGenericRepository<Product> repo) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts(
        string? brand,
        string? category,
        string? sort
    )
    {
        var spec = new ProductSpecification(brand, category, sort);
        var products = await repo.ListAsync(spec);
        return Ok(products);
    }

    [HttpGet("{id:int}")] // api/products/2
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await repo.GetByIdAsync(id);

        if (product == null)
            return NotFound();

        return product;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        repo.Add(product);

        if (await repo.SaveAllAsync())
        {
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        return BadRequest("Problem creating product");
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateProduct(int id, Product product)
    {
        if (product.Id != id || !ProductExists(id))
            return BadRequest("Cannot update this product");

        repo.Update(product);

        if (await repo.SaveAllAsync())
        {
            return NoContent();
        }

        return BadRequest("Problem updating the product");
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        var product = await repo.GetByIdAsync(id);

        if (product == null)
            return NotFound();

        repo.Delete(product);

        if (await repo.SaveAllAsync())
        {
            return NoContent();
        }

        return BadRequest("Problem deleting the product");
    }

    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<string>>> GetBrands()
    {
        var spec = new BrandListSpecification();
        var brands = await repo.ListAsync(spec);
        return Ok(brands);
    }

    [HttpGet("categories")]
    public async Task<ActionResult<IReadOnlyList<string>>> GetCategories()
    {
        var spec = new CategoryListSpecification();
        var categories = await repo.ListAsync(spec);
        return Ok(categories);
    }

    private bool ProductExists(int id)
    {
        return repo.Exists(id);
    }
}
