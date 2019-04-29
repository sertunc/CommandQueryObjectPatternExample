using System.Data;

namespace CommandQueryObjectPatternExample.Command
{
    public interface ICommand
    {
        void Execute(IDbConnection db);
    }
}
