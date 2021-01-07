namespace Store.Web.Data
{
    using Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository
    {
        void AddProduct(Product product);

        Product GetProduct(int id);

        IEnumerable<Product> GetProducts();

        bool ProductExists(int id);

        void RemoveProduct(Product product);

        Task<bool> SaveAllAsync();

        void UpdateProduct(Product product);

    }
}