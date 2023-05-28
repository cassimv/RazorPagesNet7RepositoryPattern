using BusinessLogic.StudentBusiness;
using DataLogic.LogicInterfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewLogic;

namespace NetCoreRepositoryPatternTemplate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IStudentLogic _studentLogic;
        public List<StudentView> _studentView;

        public IndexModel(ILogger<IndexModel> logger, IStudentLogic studentLogic)
        {
            _logger = logger;
            _studentLogic = studentLogic;

        }

        public async Task OnGetAsync()
        {
            _studentView = await _studentLogic.GetAllStudentsAsync();
            Page();
        }
    }
}