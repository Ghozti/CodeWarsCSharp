using System;
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

        public static string[] TowerBuilder(int nFloors)
        {
            if (nFloors == 0) return new string[] { };
            if (nFloors == 1) return new string[] { "*" };
            string star = "";
            string spcCount = "";
            string[] tower = new string[nFloors];
            string[] space = new string[nFloors-1];
            string[] reverseSpace = new string[nFloors-1];

            for(int i = 0; i < space.Length; i++)
            {
                if (i == 0) space[i] = "";
                spcCount += " "; 
                space[i] = spcCount;
            }

            int currentInt = space.Length-1;

            for(int i = 0; i < reverseSpace.Length; i++)
            {
                reverseSpace[i] = space[currentInt];
                currentInt--;
            }

            for(int i = 0; i < reverseSpace.Length + 1; i++)
            {
              if(i < reverseSpace.Length)
               {
                    if (i == 0)
                    {
                        star = "*";
                    }
                    else
                    {
                        star += "**";
                    }
                    tower[i] = reverseSpace[i] + star + reverseSpace[i];
                }
                else
                {
                    star += "**";
                    tower[i] = star;
                }
            }
            
            return tower;
        }
        /********************************************************************************************************************************************************************/

        public static int[] TwoSum(int[] numbers, int target)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j= i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }


            return new int[0];
        }

        /********************************************************************************************************************************************************************/

        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            if(startPriceOld >= startPriceNew)
            {
                return new int[] { 0, startPriceOld - startPriceNew };
            }
            else
            {
                double currentBalance = 0;
                int monthsPassed = 0;
                double oldCarVal = startPriceOld;
                double newCarVal = startPriceNew;
                //CODE WARS LINK: https://www.codewars.com/kata/554a44516729e4d80b000012/train/csharp
                //TODO this
                while (currentBalance <= newCarVal)
                {

                    monthsPassed++;
                    percentLossByMonth -= .05;
                    Console.WriteLine( oldCarVal - oldCarVal * (percentLossByMonth / 100));
                    oldCarVal = oldCarVal - (oldCarVal * (percentLossByMonth/100));
                    newCarVal = newCarVal - (newCarVal * (percentLossByMonth/100));
                    currentBalance = oldCarVal + savingPerMonth;
                    Console.WriteLine("**");

                    if (currentBalance >= oldCarVal)
                    {
                        return new int[] { monthsPassed, (int)(currentBalance - oldCarVal) };
                    }
                }
            }
            return null;
        }

        public static int[] FoldArray(int[] array, int runs)
        {
            
            return new int[] { 0 };
        }
    }
}
