using CommandQueryObjectPatternExample.Command;
using CommandQueryObjectPatternExample.Query;
using System.Data;

namespace CommandQueryObjectPatternExample.DataContext
{
    public class FooDatabase : IFooDatabase
    {
        private readonly IDbConnection _dbConnection;

        public FooDatabase(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public T Execute<T>(IQuery<T> query)
        {
            return query.Execute(_dbConnection);
        }

        public void Execute(ICommand command)
        {
            command.Execute(_dbConnection);
        }
    }
}
