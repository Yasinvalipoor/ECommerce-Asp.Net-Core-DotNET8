using Microsoft.AspNetCore.Mvc;
using Store.Operation;

namespace Store.Components
{
    public class SideMenuNavBarViewComponent : ViewComponent
    {
        private readonly IPeopleReader peopleReader;
        public SideMenuNavBarViewComponent(IPeopleReader peopleReader)
        {
            this.peopleReader = peopleReader;
        }

        public IViewComponentResult Invoke()
        {
            var currentCategory = RouteData.Values["categoryCustomers"];
            ViewBag.Category = currentCategory;
            return View(peopleReader.GetAllCategory());
        }
    }
}
