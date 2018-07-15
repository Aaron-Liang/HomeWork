using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork.Service
{
    public class CommonService
    {
        //產生整數陣列,依傳入參數num決定產生多少個陣列元素
        public int[] GetRandomValue(int num, int endValue)
        {
            Random rdn = new Random(Guid.NewGuid().GetHashCode());
            int[] Nums = new int[num];
            //Array.Clear(Nums, 0, 12);
            for (int i = 0; i < num; i++)
            {
                Nums[i] = rdn.Next(1, endValue);
            }

            rdn = null;
            return Nums;
        }
    }
}