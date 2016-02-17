namespace CQRS.Commands
{
    public class CreateStudentCommand : ICommand
    {
        public string Name { get; set; }
    }
}
