using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ViewModels.Models;

namespace ViewModels
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewModels.Controllers.DogController.furList.Add(new Models.Fur 
            { 
                Id = 1, 
                Color = ColorEnum.Schwarz 
            });

            ViewModels.Controllers.DogController.furList.Add(new Models.Fur
            {
                Id = Controllers.DogController.furList.Count + 1,
                Color = ColorEnum.Orange
            });

            ViewModels.Controllers.DogController.furList.Add(new Models.Fur
            {
                Id = Controllers.DogController.furList.Count + 1,
                Color = ColorEnum.Braun
            });

            ViewModels.Controllers.DogController.furList.Add(new Models.Fur
            {
                Id = Controllers.DogController.furList.Count + 1,
                Color = ColorEnum.Andere
            });

            Controllers.DogController.dogsList.Add(new Models.Dog
            {
                Id = 1,
                Age = 12,
                Name = "Donald",
                FurId = 2
            });

            Controllers.DogController.dogsList.Add(new Models.Dog
            {
                Id = Controllers.DogController.dogsList.Count + 1,
                Age = 91,
                Name = "Pluto",
                FurId = 3
            });

            Controllers.DogController.dogsList.Add(new Models.Dog
            {
                Id = Controllers.DogController.dogsList.Count + 1,
                Age = 67,
                Name = "Lassie",
                FurId = 4
            });
        }
    }
}
