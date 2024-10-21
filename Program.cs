namespace todo_list_project;

class Program
{
    // Create choice menu
    enum UserChoice
    {
        AddItem = 1,
        DeleteTask,
        Exit
    }
    static void Main(string[] args)
    {
        List<string> toDoList = new List<string>();
        bool exit = false;

        // Write list contents, repeat until exit option
        while (exit == false)
        {
            // Write list unless emtpy
            int choice = 0;
            if (toDoList.Count > 0)
            {
                Console.WriteLine("To-do List:");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine("- " + toDoList[i]);
                }
                Console.WriteLine("");
            }

            // Write list if empty
            else if (toDoList.Count == 0)
            {
                Console.WriteLine("Your list is empty");
                Console.WriteLine("");
            }

            // Input readline to choose menu options, run until menu chosen
            string? item = null;
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Delete item");
                Console.WriteLine("3. Exit");
                string? choiceRaw = Console.ReadLine();

                if (choiceRaw == null)
                {
                    continue;
                }

                // Convert to int, if not write message
                try
                {
                    choice = int.Parse(choiceRaw);
                }
                catch (System.Exception)
                {
                    Console.Clear();
                    Console.WriteLine("To-do List:");
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("- " + toDoList[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Use a number");
                    Console.WriteLine("-------------");
                }
            }

            // Option to input item for list
            if (choice == (int)UserChoice.AddItem)
            {
                Console.WriteLine("Enter item:");
                item = Console.ReadLine();
                if (item != null)
                {
                    toDoList.Add(item);
                }
                // Console.Clear();
                Console.WriteLine("Item added successfully!");
            }

            // Option to delete item from list
            else if (choice == (int)UserChoice.DeleteTask)
            {
                int taskNum = 0;
                bool taskNumInt = false;
                while (taskNumInt == false)
                {
                    if (toDoList.Count > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the number of the task you want to delete");
                        Console.WriteLine("--Type 99 to exit--");
                        for (int i = 0; i < toDoList.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ")" + toDoList[i]);
                        }
                        try
                        {
                            taskNum = int.Parse(Console.ReadLine());
                            if (taskNum == 99)
                            {
                                taskNumInt = true;
                            }
                        }
                        catch
                        {
                            continue;
                        }

                        // Delete item if input matches list entry number
                        if (taskNum >= 0 && taskNum < toDoList.Count)
                        {
                            if (taskNum >= 1)
                            {
                                toDoList.RemoveAt(taskNum - 1);
                                // Console.Clear();
                                Console.WriteLine($"Deleted {item}");
                                Console.WriteLine("Task deleted successfully");
                                Console.WriteLine("");
                                taskNumInt = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid task number.");
                            Console.WriteLine("");
                        }
                    }
                }
            }

            // Choice to exit menu
            else if (choice == (int)UserChoice.Exit)
            {
                exit = true;
            }
        }
    }
}