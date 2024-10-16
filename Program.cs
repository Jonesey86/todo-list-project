namespace todo_list_project;

class Program
{
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

        while (exit == false)
        {
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
            else if (toDoList.Count == 0)
            {
                Console.WriteLine("Your list is empty");
                Console.WriteLine("");
            }

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

                try
                {
                    choice = int.Parse(choiceRaw);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("Use a number");
                }
            }

            if (choice == (int)UserChoice.AddItem)
            {
                Console.WriteLine("Enter item:");
                item = Console.ReadLine();
                if (item != null)
                {
                    toDoList.Add(item);
                }
                Console.Clear();
                Console.WriteLine("Item added successfully!");
            }
            else if (choice == (int)UserChoice.DeleteTask)
            {
                int taskNum = 0;
                bool taskNumInt = false;
                while (taskNumInt == false)
                {
                    if (toDoList.Count > 0)
                    {
                        Console.WriteLine("Enter the number of the task you want to delete");
                        for (int i = 0; i > toDoList.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ")" + toDoList[i]);
                        }

                        try
                        {
                            taskNum = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            continue;
                        }

                        if (taskNum >= 0 && taskNum < toDoList.Count)
                        {
                            toDoList.RemoveAt(taskNum);
                            // Console.Clear();
                            Console.WriteLine($"Deleted {item}");
                            Console.WriteLine("Task deleted successfully");
                            Console.WriteLine("");
                            taskNumInt = true;
                        }
                        else
                        {
                            // Console.Clear();
                            Console.WriteLine("Invalid task number.");
                            Console.WriteLine("");
                        }
                    }
                }
            }
            else if (choice == (int)UserChoice.Exit)
            {
                exit = true;
            }
        }
    }
}