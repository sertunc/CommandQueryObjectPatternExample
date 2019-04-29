using CommandQueryObjectPatternExample.Model;
using System.Data;

namespace CommandQueryObjectPatternExample.Query.Products
{
    public class ProductDetailByIdQuery : IQuery<Product>
    {
        private readonly int _id;

        public ProductDetailByIdQuery(int id)
        {
            _id = id;
        }

        public Product Execute(IDbConnection dbConnection)
        {
            // Query...
            return new Product() { Id = _id };
        }
    }
}
