using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = 5;
            var sharedMultiple = a * b;
            var limit = 1000 - 1;

            var aMultipleCount = limit / a;
            var aMultiplesSum = (aMultipleCount * (aMultipleCount + 1) / 2) * a;

            var bMultipleCount = limit / b;
            var bMultiplesSum = (bMultipleCount * (bMultipleCount + 1) / 2) * b;

            var sharedMultipleCount = limit / sharedMultiple;
            var sharedMultiplesSum = (sharedMultipleCount * (sharedMultipleCount + 1) / 2) * sharedMultiple;

            var answer = aMultiplesSum + bMultiplesSum - sharedMultiplesSum;

            Console.WriteLine(answer);
        }
    }
}
