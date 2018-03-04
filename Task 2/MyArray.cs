using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MymyArray
    {
        private int[] myArray;

        public MymyArray(int n)
        {
            myArray = new int[Math.Abs(n)];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 40);
                Console.Write("{0}, ", myArray[i]);
            }
        }

        public void MinMax()
        {
            int min = myArray[0];
            int max = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                max = Math.Max(max, myArray[i]);
                min = Math.Min(min, myArray[i]);
            }
            Console.WriteLine("\nMax = {0}; Min = {1}", max, min);
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.Write("Sum = {0}, ", sum);
            return sum;
        }

        public void Average()
        {
            Console.WriteLine("Average = {0}, ", Sum() / myArray.Length);
        }

        public void Odd()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    Console.Write("{0} ", myArray[i]);
                }
            }
        }
    }
}
