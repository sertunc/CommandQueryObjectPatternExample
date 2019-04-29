using CommandQueryObjectPatternExample.Command;
using CommandQueryObjectPatternExample.Query;

namespace CommandQueryObjectPatternExample.DataContext
{
    public interface IFooDatabase
    {
        T Execute<T>(IQuery<T> query);

        void Execute(ICommand command);
    }
}
