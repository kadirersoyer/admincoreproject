using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Components
{
    [ViewComponent(Name = "Footer")]
    public class FooterViewComponent: ViewComponent
    {
        public FooterViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
