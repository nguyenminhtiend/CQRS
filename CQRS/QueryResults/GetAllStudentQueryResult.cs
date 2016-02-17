using System.Collections.Generic;
using CQRS.Entities;

namespace CQRS.QueryResults
{
    public class GetAllStudentQueryResult : IQueryResult
    {
        public List<Student> Students { get; set; }
    }
}
