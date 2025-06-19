using Think_Digitally_week01.Models;

namespace Think_Digitally_week01.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> _products = new List<Product>();
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public string UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return $"Product with ID {product.Id} not found";
            }
            existingProduct.ProductPrice = product.ProductPrice;
            existingProduct.ProductName = product.ProductName;

            return $"Product with the ID {product.Id} has been updated succesfully.";
        }

        public void DeleteProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                _products.Remove(existingProduct);
            }
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
