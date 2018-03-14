using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[100];
            int num = 0;
            string more = "y";
            string again;
            int i = 0;


            while (more == "y" || more == "Y")
            {
                Console.WriteLine("Enter a number between one and ten: ");

                num = Convert.ToInt32(Console.ReadLine());

                while (num < 1 || num > 10)
                {
                    Console.WriteLine("The number entered must be between 1 and 10. To enter a new number, type 'n'. To quit, type 'q'.");
                    again = Console.ReadLine();
                    while (again != "n" && again != "q")
                    {
                        Console.WriteLine("Please enter 'n' or 'q', and learn to follow instructions!");
                        again = Console.ReadLine();
                    }
                    if (again == "n")
                    {
                        Console.WriteLine("Enter the number: ");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (again == "q")
                    {
                        return;
                    }
                }
                values[i] = num;

                displayByVal(values[i]);
                displayByRef(ref values, i);
                i++;
                Console.WriteLine("\nDo you want to enter more values? [y or n]: ");
                more = Console.ReadLine();

                while (more != "n" && more != "y" && more != "N" && more != "Y")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    more = Console.ReadLine();
                }
            }

        }

        static void displayByVal(int element)
        {
            Console.WriteLine("New array element:" + element);

        }

        static void displayByRef(ref int[] array, int length)
        {
            Console.WriteLine("Current array: ");
            for (int i = 0; i <= length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
