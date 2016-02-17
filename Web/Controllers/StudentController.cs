using System.Web.Mvc;
using CQRS.CommandResults;
using CQRS.Commands;
using CQRS.Dispatchers;
using CQRS.Queries;
using CQRS.QueryResults;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly ICommandDispatcher commandDispatcher;
        private readonly IQueryDispatcher queryDispatcher;

        public StudentController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
            this.queryDispatcher = queryDispatcher;
        }
        public ActionResult Index()
        {
            return View(queryDispatcher.Dispatch<GetAllStudentQuery, GetAllStudentQueryResult>(new GetAllStudentQuery()).Students);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateStudentCommand createStudentCommand)
        {
            commandDispatcher.Dispatch<CreateStudentCommand, CreateStudentCommandResult>(createStudentCommand);
            return RedirectToAction("Index");
        }
    }
}