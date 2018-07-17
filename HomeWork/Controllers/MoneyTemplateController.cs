using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork.Models;
using HomeWork.Models.ViewModels;
using HomeWork.Service;

namespace HomeWork.Controllers
{
    public class MoneyTemplateController : Controller
    {
        SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        MoneyTemplateService moneyTemplateService = new MoneyTemplateService();

        // GET: MoneyTemplate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MoneyTemplateViewModels model)
        {
            //判斷模型繫結是否錯誤，或者有商業邏輯上是否錯誤
            if (ModelState.IsValid)
            {
                AccountBook accountBooks = new AccountBook();
                accountBooks.Id= Guid.NewGuid();
                accountBooks.Categoryyy = model.category.ToString() == "支出" ? 0 : 1;
                accountBooks.Amounttt = model.money;
                accountBooks.Dateee = model.date;
                accountBooks.Remarkkk = model.description;
                db.AccountBook.Add(accountBooks);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [ChildActionOnly]
        public ActionResult ItemList()
        {
            var model = moneyTemplateService.GetItemList();

            return View(model);
        }
    }
}