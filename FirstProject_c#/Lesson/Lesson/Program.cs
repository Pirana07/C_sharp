using System;
using System.Collections.Generic;

namespace Lesson
{


    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome list programm");
            List<string> TaskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.Write("What will u do");
                Console.WriteLine("Add task to the list '1'");
                Console.WriteLine("remove task from list '2'");
                Console.WriteLine("See list '3'");
                Console.WriteLine("exit wiith 'e' ");

                option = Console.ReadLine();

                switch (option)
                {

                    case "1":
                        Console.WriteLine("Write task that u want to add");
                        string task = Console.ReadLine();
                        TaskList.Add(task);
                     break;

                        case "2":
                            for (int i = 0; i < TaskList.Count; i++)
                            {
                                Console.WriteLine($"{i} : {TaskList[i]}");
                            }
                            Console.WriteLine("write number that u want to delete");
                            int dlt = int.Parse(Console.ReadLine());
                            TaskList.RemoveAt(dlt);
                         
                         break;

                        case "3":

                            Console.WriteLine("Ur current task is: ");
                            for (int i = 0;i < TaskList.Count; i++)
                        {
                            Console.WriteLine(TaskList[i]);
                        }
                        break;
                        case "e":
                            Console.WriteLine("program closed");
                        break;
                }


            }
        }

    }
}
