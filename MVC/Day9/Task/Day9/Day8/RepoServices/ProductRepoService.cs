using Day9.Models;
using Day9.Models;
using Microsoft.EntityFrameworkCore;

namespace Day9.RepoServices
{
    public class ProductRepoService : IProductRepository
    {
        ProductCustomerContext Context { get; }
        public ProductRepoService(ProductCustomerContext context)
        {
            Context = context;
        }
        public void DeleteProduct(int id)
        {
            var product = Context.Products.Find(id);
            if (product != null)
            {
                Context.Products.Remove(product);
                Context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            return Context.Products.Include(p=>p.Customer).ToList();
        }

        public Product GetDetails(int id)
        {
            return Context.Products.Include(p => p.Customer).FirstOrDefault(p => p.ID == id);
        }

        public void Insert(Product product)
        {
            Context.Products.Add(product);
            Context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var editedProduct = Context.Products.FirstOrDefault(p => p.ID == product.ID);
            if (editedProduct != null)
            {
                editedProduct.Name = product.Name;
                editedProduct.Image = product.Image;
                editedProduct.Price = product.Price;
                editedProduct.Description = product.Description;
                editedProduct.CustID = product.CustID;
                Context.SaveChanges();
            }
        }
    }
}
