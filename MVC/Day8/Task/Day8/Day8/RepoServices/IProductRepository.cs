using Day8.Models;

namespace Day8.RepoServices
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
        public Product GetDetails(int id);
        public void Insert(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
