using Admin_Pannel_Embeded.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Admin_Pannel_Embeded.Components
{
    public class Nav2ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Nav> navs = new List<Nav>()
            {
                new Nav() { Id=1, Name="Home V1", Action="Index" },
                new Nav() { Id=2, Name="Home V2", Action="IndexV1" },
            };

            return View(navs); 
        }
    }
}
