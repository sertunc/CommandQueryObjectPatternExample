using CommandQueryObjectPatternExample.Command.Products;
using CommandQueryObjectPatternExample.DataContext;
using CommandQueryObjectPatternExample.Model;
using CommandQueryObjectPatternExample.Query.Products;
using Microsoft.AspNetCore.Mvc;

namespace CommandQueryObjectPatternExample
{
    public class ProductController : Controller
    {
        private readonly IFooDatabase _fooDatabase;

        public ProductController(IFooDatabase fooDatabase)
        {
            _fooDatabase = fooDatabase;
        }

        public void UpdateProduct(int productId, string productName)
        {
            var product = _fooDatabase.Execute(new ProductDetailByIdQuery(productId));
            if (product == null)
            {
                product = new Product() { Name = productName };

                _fooDatabase.Execute(new CreateProductCommand(product));
            }
        }
    }
}