using CQRS.CommandResults;
using CQRS.Commands;

namespace CQRS.Dispatchers
{
    public interface ICommandDispatcher
    {
        TCommandResult Dispatch<TCommand, TCommandResult>(TCommand command)
            where TCommand : ICommand
            where TCommandResult : ICommandResult;
    }
}
