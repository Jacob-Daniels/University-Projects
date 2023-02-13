using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_A_B
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
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tPlease choose an option below by typing in the number:\n");
            Console.WriteLine("\t\t1)  Add a word into the BSTree");
            Console.WriteLine("\t\t2)  Traverse and display the tree (in-order, post-order or pre-order)");
            Console.WriteLine("\t\t3)  Display the height of the tree");
            Console.WriteLine("\t\t4)  Display the total number of nodes in the tree");
            Console.WriteLine("\t\t5)  Check a word is present in the tree\n");
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
                } else if (value == 0)
                {
                    state = -1;
                    return;
                }
            }
        }
        public bool EnterWord(ref string buffer)
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tEnter a word to add to the tree\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get input and clear console
            UserInput(ref buffer);
            // Validate input
            if (!TextValidation(buffer))
            {
                buffer = $"Error! Input must only contain characters!\n\t\tCould not add word: {buffer}";
                return false;
            }
            return true;
        }

        public void IsWordPresent(ref string buffer)
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tEnter a word to check if it is in the tree\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get and check user input
            UserInput(ref buffer);
        }
        public void OrderMenu()
        {
            Console.WriteLine(printFormat + " Menu:");
            Console.WriteLine("\t\tPlease choose an option below by typing in the number:\n");
            Console.WriteLine("\t\t1)  Traverse the tree In-Order");
            Console.WriteLine("\t\t2)  Traverse the tree Pre-Order");
            Console.WriteLine("\t\t3)  Traverse the tree Post-Order\n");
            Console.WriteLine("\t\t0)  Close the program\n");
            Console.WriteLine(printFormat + " Input:");
            // Get and check user input
            Console.Write("\n\t\tEnter number: ");
            string input = Console.ReadLine();
            if (NumberValidation(input))
            {
                int value = Int32.Parse(input);
                switch (value)
                {
                    case 0:
                        state = -1;
                        break;
                    case 1:
                        state = 6;
                        break;
                    case 2:
                        state = 7;
                        break;
                    case 3:
                        state = 8;
                        break;
                }
            }
        }

        private void UserInput(ref string buffer)
        {
            Console.Write("\n\t\tEnter word: ");
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
