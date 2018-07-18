using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using HomeWork.Models.CommonModels;
using HomeWork.Validation;

namespace HomeWork.Models.ViewModels
{
    public class MoneyTemplateViewModels
    {
        [Required(ErrorMessage = "類別 必須輸入!")]
        [Display(Name = "類別")]
        public CategoryCommonModels Category { get; set; }

        [Required(ErrorMessage = "金額 必須輸入!")]
        [Range(0, 32767, ErrorMessage = "只能輸入正整數!")]
        [Display(Name = "金額")]
        public int Money { get; set; }

        //[Required(ErrorMessage = "日期 必須輸入!")]
        [DataType(DataType.Date)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "日期不得大於今天!")]
        [Display(Name = "日期")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "備註 必須輸入!")]
        [StringLength(100, ErrorMessage = "最多輸入100個字元!")]
        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}