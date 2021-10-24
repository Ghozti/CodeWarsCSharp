using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp {
    class KYU8 {
        public static int CountSheeps(bool[] sheeps) {
            int sheep = 0;
            foreach(bool i in sheeps) { 
                if(i == true) {
                    sheep++;
                }
            }
            return sheep;
        }
    }
}
