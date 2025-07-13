using BikeShop.Application;
using BikeShop.Domain;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _productRepository.GetAllProducts();
    }
    [HttpPost]
    public IActionResult AddProduct([FromBody] Product product)
    {
        _productRepository.AddProduct(product);
        return Ok(new { message = "Ürün başarıyla eklendi.", data = product });
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var result = _productRepository.DeleteProduct(id);
        if (result)
            return Ok(new { message = "Ürün başarıyla silindi." });
        else
            return NotFound(new { message = "Ürün bulunamadı." });
    }

}

