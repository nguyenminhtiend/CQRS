using Autofac;
using CQRS.CommandResults;
using CQRS.Commands;
using CQRS.Handlers;

namespace CQRS.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext componentContext;
        public CommandDispatcher(IComponentContext componentContext)
        {
            this.componentContext = componentContext;
        }
        public TCommandResult Dispatch<TCommand, TCommandResult>(TCommand command) where TCommand : ICommand where TCommandResult : ICommandResult
        {
            var handler = componentContext.Resolve<ICommandHandler<TCommand, TCommandResult>>();
            return handler.Execute(command);
        }
    }
}
