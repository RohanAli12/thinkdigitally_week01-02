using Think_Digitally_week01.Models;
using Think_Digitally_week01.Repositories;

namespace Think_Digitally_week01.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public string AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return $"Product ({product.ProductName}) successfully added!";
        }

        public ProductService(IProductRepository productRepository) 
        { 
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public string UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            _productRepository.DeleteProduct(product);
        }
    }
}
