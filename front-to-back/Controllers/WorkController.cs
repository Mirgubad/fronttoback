using front_to_back.Models;
using front_to_back.ViewModels.Work;
using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            var ourworks = new List<OurWork>
            {
                new OurWork{FilePath="/assets/img/our-work-01.jpg",Title="Digital Marketing",Text=" Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor incididunt ut labore et dolor.",Type="project marketing social business"},
                new OurWork{FilePath="/assets/img/our-work-02.jpg",Title="Corporate Branding",Text="Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",Type="project graphic social"},
                  new OurWork{FilePath="/assets/img/our-work-03.jpg",Title="Leading Digital Solution",Text=" Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiatdolore eu fugiat nulla pariatur.",Type="project marketing graphic business"},
                    new OurWork{FilePath="/assets/img/our-work-04.jpg",Title="Smart Applications",Text=" Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",Type="project social business"},
                      new OurWork{FilePath="/assets/img/our-work-05.jpg",Title="Corporate Stationary",Text=" Excepteur sint occaecat cupidatat non proident,culpa qui officia deserunt mollit anim id est laborum.", Type = "project marketing"},
                        new OurWork{FilePath="/assets/img/our-work-06.jpg",Title="8 Financial Tips",Text=" Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",Type = "project marketing graphic"}
            };

            var model = new WorkIndexViewModel
            {
                OurWorks = ourworks

            };
            return View(model);
        }
    }
}
