using PharmacyDBMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Security.Cryptography.X509Certificates;

namespace PharmacyDBMS.Services
{
    public class ProductServices
    {
        private IDbContextFactory<PharmacyContext> _dbContextFactory;

        public ProductServices(IDbContextFactory<PharmacyContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddProduct(Product product)
        {
            using (PharmacyContext context = _dbContextFactory.CreateDbContext())
            {
                context.Products.Add(product);
                context.SaveChanges(); // save to db
            }
        }

        public Product GetProduct(string name)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
            var product = context.Products.SingleOrDefault(x => x.name == name);
                return product;
            }
        
        }

        public void UpdateProduct(string name, int stockAmount, float price, float discount )
        {
            var product = GetProduct(name);
            if (product != null)
            {
                throw new Exception("Product does not exist.");
            }
            else
            {
                product.stockAmount = stockAmount;
                product.price = price;
                product.discount = discount;
                // updating the product in the database
                using(var context = _dbContextFactory.CreateDbContext())
                { 
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                
            }
        }
    }
}