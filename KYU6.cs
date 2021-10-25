﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp
{
    class KYU6
    {
        /**************************************************************************************************/
        public static int Test(string numbers)
        {

            int[] lst = convert(numbers);
            int evencount = 0, oddcount = 0;
            int[] evens = new int[lst.Length], odds = new int[lst.Length];

            for (int i = 0; i < lst.Length; i++)
            {
                if (lst[i] % 2 == 0)
                {
                    evens[0] = i;
                    evencount++;
                }
                else
                {
                    odds[0] = i;
                    oddcount++;
                }
            }

            if (oddcount > evencount)
            {
                return evens[0] + 1;
            }
            else
            {
                return odds[0] + 1;
            }
        }

        private static int[] convert(string str)
        {
            string[] nums = new string[str.Length];
            string[] finalStrLst;
            int currentInd = 0;

            foreach (char i in str)
            {
                if (i != ' ')
                {
                    nums[currentInd] += i;
                }
                else
                {
                    currentInd++;
                }
            }

            int size = 0;

            foreach (string i in nums)
            {
                if (i != null)
                {
                    size++;
                }
            }

            finalStrLst = new string[size];

            for (int i = 0; i < size; i++)
            {
                finalStrLst[i] = nums[i];
            }

            int[] numList = new int[size];
            int currentInd2 = 0;

            foreach (string i in finalStrLst)
            {
                numList[currentInd2] = Int32.Parse(i);
                currentInd2++;
            }

            return numList;
        }
        /**************************************************************************************************/
    }
}