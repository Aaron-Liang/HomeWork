using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HomeWork.Validation
{
    public sealed class BanWordAttribute : ValidationAttribute
    {
        public DateTime Input { get; set; }

        public BanWordAttribute(DateTime input)
        {
            this.Input = input;
        }

        public override bool IsValid(object value)
        {
            //沒有輸入也算錯
            if (value == null)
            {
                return false;
            }

            if (value is DateTime)
            {
                //輸入值是字串才判斷
                if (this.Input > DateTime.Now)
                {
                    return false;
                }
            }
            return true;
        }
    }
}