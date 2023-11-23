using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsDotNet
{
    internal class Implement : OddEvenPrimeFibinocci
    {
        int number;
        int[] numArray;
        int[] num;
        int k = 0;
        public Implement(int num)
        {
            this.number = num;
        }
        public Implement(int[] arr)
        {
            this.num = arr;
        }
        public override void Even()
        {
            numArray = new int[10];
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    numArray[k] = i;
                    k++;
                }
            }
            Console.WriteLine("Even Numbers are---->\n");
            for (int i = 0; i < k; i++)
            {

                Console.Write($"{numArray[i]}\t");
            }
        }

        public override void Fibinocci()
        {
            //numArray = new int[number];
            //numArray[0] = 0;
            //numArray[1] = 1;
            //if (number == 1)
            //{
            //    Console.WriteLine($"Fabinocci Series is {numArray[0]}");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine($"Fabinocci Series is {numArray[1]}");
            //}
            //else
            //{
            //    for (int i = 2; i < this.number; i++)
            //    {
            //        numArray[i] = numArray[i - 1] + numArray[i - 2];
            //    }
            //    Console.WriteLine("Fabinocci Series is\n");
            //    foreach (int i in numArray)
            //    {
            //        Console.Write($"{i}\t");
            //    }
            //    Console.WriteLine("");
            //}
            int num1 = 0;
            int num2 = 1;
            if (number == 0)
            {
                Console.WriteLine(num1);
            }
            else if (number == 1)
            {
                Console.WriteLine(num2);
            }
            else
            {

                Console.Write($"{num1}\t{num2}\t");
                for (int i = 0; i < number; i++)
                {
                    num2 = num1 + num2;
                    num1 = num2 - num1;
                    Console.Write($"{num2}\t");
                }
            }
        }

        public override void Odd()
        {
            numArray = new int[15];
            foreach (int i in num)
            {
                if (i % 2 != 0)
                {
                    numArray[k] = i;
                    k++;
                }
            }
            Console.WriteLine("Odd Numbers are---->\n");
            for (int i = 0; i < k; i++)
            {

                Console.Write($"{numArray[i]}\t");
            }
        }

        public override bool Prime()
        {
            if (number <= 1) return false;
            else if (number == 2) return true;
            k = 0;
            for (int i = 2; i < this.number / 2; i++)
            {
                if (number % i == 0)
                {
                    k++;
                }
            }
            if (k != 0)
                return false;
            else
                return true;
        }
    }
}
