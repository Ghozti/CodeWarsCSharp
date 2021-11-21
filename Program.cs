using System;

namespace CodeWarsCSharp {
    class Program {
        static void Main(string[] args) {
            for(int i = 0; i < KYU6.FoldArray(new int[] { 1, 2, 3, 4, 5, 6}, 1).Length; i++)
            {
                Console.WriteLine(KYU6.FoldArray(new int[] { 1, 2, 3, 4, 5, 6}, 1)[i]);
            }
        }
    }
}
