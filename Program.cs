// namespace todo_list_project;

// class Program
// {
//     enum UserChoice
//     {
//         AddItem = 1,
//         DeleteTask,
//         Exit
//     }
//     static void Main(string[] args)
//     {
//         List<string> toDoList = new List<string>();
//         bool exit = false;

//         while (exit == false)
//         {
//             int choice = 0;
//             if (toDoList.Count > 0)
//             {
//                 Console.WriteLine("To-do List:");
//                 for (int i = 0; i < toDoList.Count; i++)
//                 {
//                     Console.WriteLine("- " + toDoList[i]);
//                 }
//                 Console.WriteLine("");
//             }
//             else if (choice == (int)UserChoice.DeleteTask)
//             {
//                 if (toDoList.Count > 0)
//                 {
//                     Console.WriteLine("Enter the number of the task you want to delete");
//                     for (int i = 0; i > toDoList.Count; i++)
//                     {
//                         Console.WriteLine("(" + (i + 1) + ")" + toDoList[i]);
//                     }

//                     int taskNum = 0;
//                     string? tempNum = Console.ReadLine();
//                     if (tempNum != null)
//                     {
//                         taskNum = int.Parse(tempNum);
//                     }

//                     if (taskNum != 0 || taskNum > toDoList.Count)
//                         if (taskNum >= 0 && taskNum < toDoList.Count)
//                         {
//                             toDoList.RemoveAt(taskNum);
//                             Console.Clear();
//                             Console.WriteLine("Task deleted successfully");
//                             Console.WriteLine("");
//                         }
//                         else
//                         {
//                             Console.Clear();
//                             Console.WriteLine("Invalid task number.");
//                             Console.WriteLine("");
//                         }
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Your list is empty");
//                 Console.WriteLine("");
//             }

//             Console.WriteLine("1. Add item");
//             Console.WriteLine("2. Delete item");
//             Console.WriteLine("3. Exit");
//             string? choiceRaw = Console.ReadLine();
//             string? item = null;
//             Console.WriteLine("Enter item:");
//             item = Console.ReadLine();

//             if (choiceRaw == null)
//             {
//                 continue;
//             }

//             choice = int.Parse(choiceRaw);

//             if (choice != (int)UserChoice.AddItem || item != null || choice != (int)UserChoice.DeleteTask || choice != (int)UserChoice.Exit)
//             {
//                 continue;
//             }
//             else if (choice == (int)UserChoice.AddItem)
//             {
//                 if (item != null)
//                 {
//                     toDoList.Add(item);
//                     Console.Clear();
//                     Console.WriteLine("Item added successfully!");
//                 }
//             }
//             else if (choice == (int)UserChoice.Exit)
//             {
//                 exit = true;
//             }
//         }
//     }
// }