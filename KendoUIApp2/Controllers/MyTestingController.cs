using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIApp2.Models;

namespace KendoUIApp2.Controllers
{
    public class MyTestingController : Controller
    {
        // GET: MyTesting
        private List<TestingModel> models = new List<TestingModel>
        {
            new TestingModel{Id = 14, Name = "object 14"},
            new TestingModel{Id = 1, Name = "object 1"},
            new TestingModel{Id = 2, Name = "object 2"},
            new TestingModel{Id = 11, Name = "object 11"},
            new TestingModel{Id = 3, Name = "object 3"},
            new TestingModel{Id = 4, Name = "object 4"},
            new TestingModel{Id = 5, Name = "object 5"},
            new TestingModel{Id = 10, Name = "object 10"},
            new TestingModel{Id = 9, Name = "object 9"},
            new TestingModel{Id = 6, Name = "object 6"},
            new TestingModel{Id = 12, Name = "object 12"},
            new TestingModel{Id = 7, Name = "object 7"},
            new TestingModel{Id = 8, Name = "object 8"},
            new TestingModel{Id = 13, Name = "object 13"},
        };

        public ActionResult Testing()
        {
            ViewBag.Models = models;
            return View();
        }

        public ActionResult GetProducts([DataSourceRequest] DataSourceRequest dataSourceRequest)
        {
            DataSourceResult result = models.ToDataSourceResult(dataSourceRequest);
            return Json(result);
        }
    }
}