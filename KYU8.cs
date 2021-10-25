using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp {
    class KYU8 {
        /*
         * given an array of booleans, count every boolean that is true and return the count
         */
        public static int CountSheeps(bool[] sheeps) {
            int sheep = 0;
            foreach(bool i in sheeps) { 
                if(i == true) {
                    sheep++;
                }
            }
            return sheep;
        }


        //given an array, calculate the average of the values
        public static double FindAverage(double[] array){
            if(array.Length == 0 || array == null) { return 0; }
            int size = array.Length;
            double sum = 0;
            foreach(double i in array) {
                sum += i;
            }
            return sum/size;
        }
    }
}
