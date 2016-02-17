using System.Linq;
using CQRS.Context;
using CQRS.Queries;
using CQRS.QueryResults;

namespace CQRS.Handlers
{
    public class GetAllStudentHandler : IQueryHandler<GetAllStudentQuery, GetAllStudentQueryResult>
    {
        private readonly CqrsContext context;

        public GetAllStudentHandler(CqrsContext context)
        {
            this.context = context;
        }
        public GetAllStudentQueryResult Execute(GetAllStudentQuery query)
        {
            return new GetAllStudentQueryResult { Students = context.Students.ToList() };
        }
    }
}
