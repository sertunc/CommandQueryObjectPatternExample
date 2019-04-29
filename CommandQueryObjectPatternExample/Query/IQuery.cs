using System.Data;

namespace CommandQueryObjectPatternExample.Query
{
    public interface IQuery<T>
    {
        T Execute(IDbConnection dbConnection);
    }
}
