using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersicesConsoleApp.DataStructures
{
    public class Arrays
    {
        public int FindDuplicateInArrangedNumbers(int[] arr)
        {
            int currentSum = arr.Sum();

            int correctSum = 0;
            for (int i = 1; i < arr.Length; i++)
                correctSum += i;

            return currentSum - correctSum;




        }
    }
}
