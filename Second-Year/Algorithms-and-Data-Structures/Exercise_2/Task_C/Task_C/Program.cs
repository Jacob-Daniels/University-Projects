using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuDrivenInterface menuInterface = new MenuDrivenInterface();
            AVLTree<string> AVLTree = new AVLTree<string>();
            string buffer = "";
            string outputText = "";

            // Main program loop
            while (menuInterface.State != -1)
            {
                Console.Clear();
                buffer = "";
                menuInterface.OutputText(outputText);
                switch (menuInterface.State)
                {
                    case 0: // Display menu of inputs
                        menuInterface.Menu();
                        outputText = buffer;
                        break;
                    case 1: // Insert item
                        if (menuInterface.EnterText(ref buffer))
                        {
                            AVLTree.InsertItem(buffer);
                            outputText = "Added: " + buffer;
                        } else
                        {
                            outputText = $"Error!\n\t\tCould not add text: {buffer}\n\n\t\tInput must only contain characters (No spaces, numbers or special characters)!";
                        }
                        break;
                    case 2: // Remove item
                        menuInterface.RemoveText(ref buffer);
                        // Check if item can be removed from the tree
                        if (AVLTree.RemoveItem(buffer))
                        {
                            outputText = "Removed: " + buffer;
                        } else
                        {
                            outputText = "Could not remove: " + buffer + "\n\t\tIt is not in the tree!";
                        }
                        break;
                    case 3: // Is item present
                        menuInterface.IsTextPresent(ref buffer);
                        outputText = $"Is the text '{buffer}' in the tree?   {AVLTree.TreeContains(buffer)}";
                        if (AVLTree.TreeContains(buffer))
                        {
                            outputText += $"\n\n\t\tHow many of '{buffer}' are stocked?   {AVLTree.FindNode(buffer).Total}";
                        }
                        break;
                    case 4: // Display tree orders
                        AVLTree.InOrder(ref buffer);
                        outputText = "In-order: " + buffer;
                        buffer = "";
                        AVLTree.PreOrder(ref buffer);
                        outputText += "\n\t\tPre-order: " + buffer;
                        buffer = "";
                        AVLTree.PostOrder(ref buffer);
                        outputText += " \n\t\tPost-order: " + buffer;
                        menuInterface.State = 0;
                        break;
                    case 5: // Display tree height and total nodes
                        outputText = "Tree height: " + AVLTree.TreeHeight();
                        outputText += "\n\t\tTotal nodes: " + AVLTree.CountNodes();
                        outputText += "\n\t\tTotal items: " + AVLTree.CountNodeItems();
                        menuInterface.State = 0;
                        break;
                }
            }
        }
    }
}