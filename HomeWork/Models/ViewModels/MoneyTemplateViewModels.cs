using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using HomeWork.Models.CommonModels;

namespace HomeWork.Models.ViewModels
{
    public class MoneyTemplateViewModels
    {
        [Required(ErrorMessage = "類別 必須輸入!")]
        [Display(Name = "類別")]
        public CategoryCommonModels category { get; set; }

        [Required(ErrorMessage = "金額 必須輸入!")]
        [Display(Name = "金額")]
        public int money { get; set; }

        [Required(ErrorMessage = "日期 必須輸入!")]
        [DataType(DataType.Date)]
        [Display(Name = "日期")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "備註 必須輸入!")]
        [Display(Name = "備註")]
        public string description { get; set; }
    }
}