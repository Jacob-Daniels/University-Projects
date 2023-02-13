using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_B
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            MenuDrivenInterface menu = new MenuDrivenInterface();
            bool loop = true;
            string outputText = "";
            #region Populate list
            // Populate list
            students.Add(new Student("Dylan", 19));
            students.Add(new Student("Nicola", 40));
            students.Add(new Student("Andrew", 37));
            students.Add(new Student("Paul", 57));
            students.Add(new Student("Ellie", 22));
            students.Add(new Student("Rita", 67));
            #endregion
            // Main loop
            while (loop)
            {
                Console.Clear();
                menu.OutputText(outputText);
                switch (menu.state)
                {
                    case -1:
                        loop = false;
                        break;
                    case 0:
                        // Display main menu
                        if (!menu.MainMenu())
                        {
                            outputText = "Invalid input!\n\t\tTry again...";
                        } else
                        {
                            outputText = "";
                        }
                        break;
                    case 1:
                        // Add student
                        string name = ""; int age = 0;
                        if (menu.AddStudent(ref name, ref age))
                        {
                            students.Add(new Student(name, age));
                            menu.state = 0;
                            outputText = "";
                        } else
                        {
                            outputText = "Invalid input!\n\t\tCould not add student to list!";
                        }
                        break;
                    case 2:
                        // Display current list order
                        int i = 0;
                        while (i < students.Count)
                        {
                            outputText += students[i].Name.ToString() + ", aged " + students[i].Age.ToString() + "\n\t\t";
                            i++;
                        }
                        menu.state = 0;
                        break;
                    case 3:
                        // Sort by name
                        string[] studentNames = new string[students.Count];
                        int j = 0;
                        while (j < students.Count)
                        {
                            studentNames[j] = students[j].Name;
                            j++;
                        }
                        DisplayArray(studentNames, ref outputText);
                        menu.state = 0;
                        break;
                    case 4:
                        // Sort by age
                        int[] studentAges = new int[students.Count];
                        int k = 0;
                        while (k < students.Count)
                        {
                            studentAges[k] = students[k].Age;
                            k++;
                        }
                        DisplayArray(studentAges, ref outputText);
                        menu.state = 0;
                        break;
                }
            }
        }

        static public void DisplayArray<T>(T[] array, ref string outputText) where T : IComparable
        {
            // Display array
            outputText = "Unsorted:";
            int i = 0;
            while (i < array.Length)
            {
                outputText += $"{array[i]}, ";
                i++;
            }

            // Display sorted array
            SelecSortGen(array);
            outputText += "\n\t\tSorted: ";
            i = 0;
            while (i < array.Length)
            {
                outputText += $"{array[i]}, ";
                i++;
            }
        }


        static public void SelecSortGen<T>(T[] array) where T : IComparable
        {
            // Loop array
            for (int i = 0; i < array.Length - 1; i++)
            {
                int smallest = i;
                // Loop array again to find smallest value
                for (int j = i + 1; j < array.Length; j++)
                {
                    // Check value at index 'j' is less than value at index 'smallest'
                    if (array[j].CompareTo(array[smallest]) == -1)
                    {
                        smallest = j;
                    }
                }
                // Swap values to sort array
                Swap(ref array[i], ref array[smallest]);
            }
        }

        static public void Swap<T>(ref T x, ref T y) where T : IComparable
        {
            // Swap values
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
