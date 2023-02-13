using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_C
{
    class MenuDrivenInterface
    {
        private int state;
        private string printFormat = "====================================================================================================\n";

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        // Methods
        public void OutputText(string data)
        {
            Console.WriteLine(printFormat + " Output:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t" + data + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Menu()
        {
            // Main menu display
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tPlease choose an option below by typing in the number:\n");
            Console.WriteLine("\t\t1)  Add a product into the AVLTree");
            Console.WriteLine("\t\t2)  Remove a product from the AVLTree");
            Console.WriteLine("\t\t3)  Check how many times a product occurs in the tree");
            Console.WriteLine("\t\t4)  Display the tree: in-order, post-order and pre-order");
            Console.WriteLine("\t\t5)  Display the total nodes, items and tree height\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get and check user input
            Console.Write("\n\t\tEnter number: ");
            string input = Console.ReadLine();
            if (NumberValidation(input))
            {
                int value = Int32.Parse(input);
                if (value >= 1 && value <= 5)
                {
                    state = value;
                    return;
                }
                else if (value == 0)
                {
                    state = -1;
                    return;
                }
            }
        }
        public bool EnterText(ref string buffer)
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tEnter a product to add to the tree\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get input and clear console
            UserInput(ref buffer);
            // Input validation
            if (!TextValidation(buffer))
            {
                return false;
            }
            return true;
        }

        public void IsTextPresent(ref string buffer)
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tEnter a product to check if it is in the tree\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get and check user input
            UserInput(ref buffer);
        }
        public void RemoveText(ref string buffer)
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tEnter a product to remove from the tree\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get and check user input
            UserInput(ref buffer);
        }

        private void UserInput(ref string buffer)
        {
            Console.Write("\n\t\tEnter product: ");
            buffer = Console.ReadLine();
            state = 0;
            // Check whether to close program
            if (NumberValidation(buffer))
            {
                int value = Int32.Parse(buffer);
                if (value == 0)
                {
                    state = -1;
                }
            }
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
