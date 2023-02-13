using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_B
{
    public class MenuDrivenInterface
    {
        // Attributes
        private string printFormat = "====================================================================================================\n";
        public int state = 0;

        // Constructor
        public MenuDrivenInterface() { }

        // Methods
        public void OutputText(string data)
        {
            Console.WriteLine(printFormat + " Output:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t" + data + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool MainMenu()
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tPlease choose an option below by typing in the number:\n");
            Console.WriteLine("\t\t1) Add a student");
            Console.WriteLine("\t\t2) Display current list order");
            Console.WriteLine("\t\t3) Sort list by student name");
            Console.WriteLine("\t\t4) Sort list by student age\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat);
            Console.Write("Input: ");
            string input = Console.ReadLine();
            // Check input is valid
            if (NumberValidation(input))
            {
                state = Int32.Parse(input);
                if (state == 1 || state == 2 || state == 3 || state == 4)
                {
                    return true;
                } else if (state == 0)
                {
                    state = -1;
                    return true;
                }
            }
            return false;
        }

        public bool AddStudent(ref string name, ref int age)
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tAdd a student to the list\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat);
            Console.Write("Enter name: ");
            // Get name input
            name = Console.ReadLine();
            if (!TextValidation(name))
            {
                return false;
            }
            Console.Write("Enter age: ");
            string getAge = Console.ReadLine();
            // Validate age input
            if (NumberValidation(getAge))
            {
                age = Int32.Parse(getAge);
                return true;
            }
            return false;
        }


        private bool NumberValidation(string input)
        {
            // Check if string contains only numbers and is not empty
            if (input != "" && Regex.IsMatch(input, "^[0-9]+$"))
            {
                return true;
            }
            return false;
        }
        private bool TextValidation(string input)
        {
            // Check if string contains only characters and is not empty
            if (input != "" && Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            return false;
        }
    }
}
