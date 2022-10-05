
using front_to_back.Models;
using front_to_back.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index()
        {

            var recentworkcomponent = new List< RecentWorkComponent> {
           
                new RecentWorkComponent{Title="Social Media",Text="Ullamco laboris nisi ut aliquip ex",FilePath="/assets/img/recent-work-01.jpg"},
                new RecentWorkComponent{Title="Web Marketing",Text="Psum officia anim id est laborum.",FilePath="/assets/img/recent-work-02.jpg"},
                new RecentWorkComponent{Title="R & D",Text="Sum dolor sit consencutur",FilePath="/assets/img/recent-work-03.jpg"},
                new RecentWorkComponent{Title="Public Relation",Text="Lorem ipsum dolor sit amet",FilePath="/assets/img/recent-work-04.jpg"},
                new RecentWorkComponent{Title="Branding",Text="Put enim ad minim veniam",FilePath="/assets/img/recent-work-05.jpg"},
                new RecentWorkComponent{Title="Creative Design",Text="Mollit anim id est laborum.",FilePath="/assets/img/recent-work-06.jpg"}

            };
            var projectcomponent = new List<ProjectComponent> {
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-01.jpg", Type = "project ui branding" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-02.jpg", Type = "project ui graphic" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-03.jpg", Type = "project branding" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-04.jpg", Type = "project ui graphic" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-05.jpg", Type = "project ui graphic" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-06.jpg", Type = "project ui branding" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-07.jpg", Type = "project ui branding" },
            new ProjectComponent { Title = "UI/UX design", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing", FilePath = "/assets/img/services-08.jpg", Type = "project ui graphic" },
};

            


            var model = new HomeIndexViewModel
            {
                RecentWorkComponents = recentworkcomponent,
                ProjectComponents = projectcomponent,   
               
            };
            

            return View(model);
        }
    }
}
