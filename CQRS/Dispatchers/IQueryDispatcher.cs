using CQRS.Queries;
using CQRS.QueryResults;

namespace CQRS.Dispatchers
{
    public interface IQueryDispatcher
    {
        TQueryResult Dispatch<TQuery, TQueryResult>(TQuery query)
            where TQuery : IQuery
            where TQueryResult : IQueryResult;
    }
}
