using AutoMapper;
using CQRS.CommandResults;
using CQRS.Commands;
using CQRS.Context;
using CQRS.Entities;

namespace CQRS.Handlers
{
    public class CreateStudentHandler : ICommandHandler<CreateStudentCommand, CreateStudentCommandResult>
    {
        private readonly CqrsContext dbContext;

        public CreateStudentHandler(CqrsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public CreateStudentCommandResult Execute(CreateStudentCommand command)
        {
            var student = Mapper.Map<CreateStudentCommand, Student>(command);
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return new CreateStudentCommandResult { StudentId = student.Id };
        }
    }
}
