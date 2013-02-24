using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Podviaznikov
{
    class SolveClass
    {
        List<int> perfectNumber = new List<int>();
        const int bound = 3000;

        public static int Sum(int naturalNumber)
        {
            int sum = 0;
            for (int i = 1; i <= naturalNumber / 2; i++)
            {
                if (naturalNumber % i == 0)
                    sum += i;
            }
            return sum;
        }

        public bool isPerfect(int number)
        {
            bool var = false;
            for (int i = 0; i < perfectNumber.Count; i++)
            {
                if (perfectNumber[i] == number)
                {
                    var = true;
                    break;
                }
            }
            return var;
        }
        public void Solver()
        {
            for (int i = 1; i <= bound; i++)
            {
                if (i == Sum(i))
                    perfectNumber.Add(i);
            }
        }
    }
}
