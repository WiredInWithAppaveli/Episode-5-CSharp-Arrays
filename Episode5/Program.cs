using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode5
{
    class Program
    {
        static void PrintArray()
        {
            string[] myArray = { "My", "First Array" };
            foreach(string s in myArray)
            {
                Console.WriteLine(s);
               
            }
            

        }
        static int[] NumberArray()
        {
            int[] myNumbers = { 2, 4, 6, 8, 10 };
            for(int i =0; i < myNumbers.Length; i++)
            {
                int x = 2;
                int y = 4;
                Console.WriteLine(i * x * y);
            }
            return myNumbers;
        }
        static void Print2DArray(string[,] arr)
        {
            for(int i =0; i < arr.GetLength(0); i++)
            {
                for(int j =0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {
            string[,] newArray = new string[,] { { "1", "2" }, { "3", "4" } , { "5", "6" } , { "7", "8" } };
            PrintArray();
            NumberArray();
            Print2DArray(newArray);
        }
    }
}
