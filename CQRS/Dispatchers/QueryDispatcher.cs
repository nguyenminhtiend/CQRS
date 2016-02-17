using Autofac;
using CQRS.Handlers;
using CQRS.Queries;
using CQRS.QueryResults;

namespace CQRS.Dispatchers
{
    public class QueryDispatcher : IQueryDispatcher
    {
         private readonly IComponentContext componentContext;
         public QueryDispatcher(IComponentContext componentContext)
        {
            this.componentContext = componentContext;
        }
        public TQueryResult Dispatch<TQuery, TQueryResult>(TQuery query) where TQuery : IQuery where TQueryResult : IQueryResult
        {
            var handler = componentContext.Resolve<IQueryHandler<TQuery, TQueryResult>>();
            return handler.Execute(query);
        }
    }
}
