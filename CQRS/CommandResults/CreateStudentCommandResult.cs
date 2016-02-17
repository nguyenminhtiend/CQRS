namespace CQRS.CommandResults
{
    public class CreateStudentCommandResult : ICommandResult
    {
        public int StudentId { get; set; }
    }
}
