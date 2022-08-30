using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    public class CouponNumber
    {
        public void Coupon()
        {
            int[] arr = new int[10];
            int[] distArr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 11); //[1,2,3,4,5,2,3,4,7,8] }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    distArr[i] = arr[i]; //distArr[0]=1 }
                }

            }
            foreach (var data in distArr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}         
