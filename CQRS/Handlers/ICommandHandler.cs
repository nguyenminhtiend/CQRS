using CQRS.CommandResults;
using CQRS.Commands;

namespace CQRS.Handlers
{
    interface ICommandHandler<in TCommand, out TCommandResult> 
        where TCommand : ICommand 
        where TCommandResult : ICommandResult
    {
        TCommandResult Execute(TCommand command);
    }
}
