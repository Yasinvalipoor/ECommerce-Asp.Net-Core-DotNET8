using Microsoft.AspNetCore.Mvc;
using Store.Operation;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private int PageSize = 1;
        private readonly IPeopleReader peopleReader;
        public HomeController(IPeopleReader peopleReader)
        {
            this.peopleReader = peopleReader;
        }
        public IActionResult Index(string categoryCustomers = "", int PageNumber=1)
        {
            return View(peopleReader.GetAll(PageNumber,PageSize, categoryCustomers));
        }
    }
}
