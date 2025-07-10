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
}

