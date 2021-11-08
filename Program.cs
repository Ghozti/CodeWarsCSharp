using System;

namespace CodeWarsCSharp {
    class Program {
        static void Main(string[] args) {
            int[] lst = KYU6.nbMonths(8000, 8000, 1000, 1.5);
            foreach(int i in lst)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
