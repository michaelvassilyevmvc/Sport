using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence.Repository.IRepository;

namespace Sport.MVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _perRepo;

        public PersonController(IPersonRepository perRepo)
        {
            _perRepo = perRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var people = await _perRepo.GetAll();
            return View(people);
        }
    }
}