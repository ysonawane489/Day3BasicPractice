using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BasicPractice
{
   class MatrixMultriplication
    {
        public static void Main()
        {
            int i, j;
            int[,] arr1 ={ { 2, 3 },{ 4,5} };
            int[,] arr2 = { { 2, 3 }, { 4, 5 } };
            int[,] arr3 = new int[2, 2];
           
            Console.Write("\nFirst matrix is:\n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j <2; j++)
                    Console.Write("   "+ arr1[i, j]);
            }
            Console.Write("\nSecond matrix is:\n");
            for (i = 0; i <2; i++)
            {
                Console.Write("\n");
                for (j = 0; j <2; j++)
                    Console.Write("   "+ arr2[i, j]);
            }

            for (i = 0; i <2; i++)
                for (j = 0; j <2; j++)
                    arr3[i, j] = arr1[i, j] * arr2[j, i];

            Console.Write("\nAdding two matrices: \n");
            for (i = 0; i <2; i++)
            {
                Console.Write("\n");
                for (j = 0; j <2; j++)
                    Console.Write("  "+ arr3[i, j]);
            }
            Console.Write("\n\n");
                   
             } 
         } 
    

