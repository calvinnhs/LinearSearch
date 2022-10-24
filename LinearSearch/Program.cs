using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of elements in the array 
        int n;
        //get the number of elements to store in the array 
        int i;

        public void input()
        {
            while(true)
            {
                Console.Write("enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\narray should have minimum 1 and maximum 20 elements.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" enter array elemnts ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++ )
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
    }
}
