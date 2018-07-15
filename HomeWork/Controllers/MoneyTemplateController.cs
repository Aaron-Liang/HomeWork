using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork.Models.ViewModels;
using HomeWork.Service;

namespace HomeWork.Controllers
{
    public class MoneyTemplateController : Controller
    {
        MoneyTemplateService moneyTemplateService = new MoneyTemplateService();

        // GET: MoneyTemplate
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ItemList()
        {
            var model = moneyTemplateService.GetItemList();

            return View(model);
        }
    }
}