using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_A_B {
    class Program
    {
        static void Main(string[] args)
        {
            MenuDrivenInterface menuInterface = new MenuDrivenInterface();
            BinarySearchTree<string> bsTree = new BinarySearchTree<string>();
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
                        if (menuInterface.EnterWord(ref buffer))
                        {
                            // Check whether item can be added
                            if (bsTree.InsertItem(buffer))
                            {
                                buffer = "Word added: " + buffer;
                            } else
                            {
                                buffer = $"Word '{buffer}' already exists in tree";
                            }
                        }
                        outputText = buffer;
                        break;
                    case 2: // Display menu of order inputs
                        menuInterface.OrderMenu();
                        break;
                    case 3: // Tree Height
                        outputText = $"Tree height: {bsTree.TreeHeight()}";
                        menuInterface.State = 0;
                        break;
                    case 4: // Tree node count
                        outputText = $"Nodes in tree: {bsTree.CountNodes()}";
                        menuInterface.State = 0;
                        break;
                    case 5: // Is item present
                        menuInterface.IsWordPresent(ref buffer);
                        bsTree.TreeContains(buffer);
                        outputText = $"Is the word '{buffer}' in the tree? {bsTree.TreeContains(buffer)}";
                        break;
                    case 6: // In-Order
                        bsTree.InOrder(ref buffer);
                        outputText = $"Tree in-order: {buffer}";
                        menuInterface.State = 0;
                        break;
                    case 7: // Pre-Order
                        bsTree.PreOrder(ref buffer);
                        outputText = $"Tree pre-order: {buffer}";
                        menuInterface.State = 0;
                        break;
                    case 8: // Post-Order
                        bsTree.PostOrder(ref buffer);
                        outputText = $"Tree post-order: {buffer}";
                        menuInterface.State = 0;
                        break;
                }
            }
        }
    }
}