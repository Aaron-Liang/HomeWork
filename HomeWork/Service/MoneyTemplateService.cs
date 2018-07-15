using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeWork.Models.ViewModels;
using HomeWork.Models.CommonModels;
namespace HomeWork.Service
{
    public class MoneyTemplateService
    {
        CommonService commonService = new CommonService();


        public IEnumerable<MoneyTemplateViewModels> GetItemList()
        {
            var arrayCategory = commonService.GetRandomValue(50, 3);
            var arrayMoney = commonService.GetRandomValue(50, 5000);

            for (var i = 0; i < 50; i++)
            {
                yield return new MoneyTemplateViewModels()
                {
                    category = arrayCategory[i] == 1 ? CategoryCommonModels.支出 : CategoryCommonModels.收入,
                    date = DateTime.Now.AddDays(i),
                    money = arrayMoney[i]
                };
            }
        }
    }
}