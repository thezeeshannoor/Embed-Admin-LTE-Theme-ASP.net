using Admin_Pannel_Embeded.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace Admin_Pannel_Embeded.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            var viewModel = new ModelView()
            {
                 NavList = new List<Nav>()
            {
                new Nav() { Id=1,Name="Home V1",Action="Index"},
                 new Nav() { Id=2,Name="Home V2",Action= "IndexV1"},
             },
                SideBar = new List<Nav>()
            {
                new Nav() { Id=1,Name="Dashboard V1",Action="Index"},
                 new Nav() { Id=2,Name="Dashboard V2",Action= "IndexV1"},
             }
        };
             
            return View(viewModel);
        }

        public IActionResult IndexV1()
        {
            var viewModel = new ModelView()
            {
                NavList = new List<Nav>()
            {
                new Nav() { Id=1,Name="Home V1",Action="Index"},
                 new Nav() { Id=2,Name="Home V2",Action= "IndexV1"},
             },
                SideBar = new List<Nav>()
            {
                new Nav() { Id=1,Name="Dashboard V1",Action="Index"},
                 new Nav() { Id=2,Name="Dashboard V2",Action= "IndexV1"},
             }
            };



            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
