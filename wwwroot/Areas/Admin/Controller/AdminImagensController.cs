using Microsoft.AspNetCore.Mvc;

namespace PaulaPachecoHairStyle.wwwroot.Areas.Admin.Controller
{
    public class AdminImagensController : Controller
    {
        private readonly ConfigurationImagens _myConfig;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AdminImagensController(IWebHostEnvironment hostingEnvironment, IOptions<ConfigurationImagens> myConfiguration
            )
        {
            _hostingEnvironment = hostingEnvironment;
            _myConfig = myConfiguration.Value;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
