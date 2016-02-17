using CQRS.Queries;
using CQRS.QueryResults;

namespace CQRS.Handlers
{
    public interface IQueryHandler<in TQuery, out TQueryResult>
        where TQuery : IQuery
        where TQueryResult : IQueryResult
    {
        TQueryResult Execute(TQuery query);
    }
}
