using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeWork.Models;
using HomeWork.Models.ViewModels;
using HomeWork.Models.CommonModels;
using Dapper;

namespace HomeWork.Service
{
    public class MoneyTemplateService
    {
        CommonService commonService = new CommonService();


        public IEnumerable<MoneyTemplateViewModels> GetItemList()
        {
            List<MoneyTemplateViewModels> moneyTemplateViewModels = new List<MoneyTemplateViewModels>();
            var Conn = new SkillTreeHomeworkEntities().Database.Connection;

            string strSQL = "select Id id, Categoryyy category, Amounttt money, Dateee date, Remarkkk description " +
                            " from AccountBook " +
                            " order by Dateee ";

            moneyTemplateViewModels = Conn.Query<MoneyTemplateViewModels>(strSQL, null).ToList();

            return moneyTemplateViewModels;
        }
    }
}