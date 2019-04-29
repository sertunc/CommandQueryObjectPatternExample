using CommandQueryObjectPatternExample.Model;
using System.Data;

namespace CommandQueryObjectPatternExample.Command.Products
{
    public class CreateProductCommand : ICommand
    {
        private readonly Product _product;

        public CreateProductCommand(Product product)
        {
            _product = product;
        }

        public void Execute(IDbConnection dbConnection)
        {
            // Commands...
        }
    }
}
