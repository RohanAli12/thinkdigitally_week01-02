using Think_Digitally_week01.Models;

namespace Think_Digitally_week01.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        string UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
