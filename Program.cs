namespace task_traker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine( " welcome to our task traker ");
            while (true)
            {
                Console.WriteLine(" press 1 to add task 2 to view all tasks 3 for mark task complete 4 for remove task 5 for exit ");
                string user_choice = Console.ReadLine();
                switch (user_choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTask();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" please enter the number between 1:5");
                        break;

                }
            }
        }
        public static void AddTask()
        {
            Console.WriteLine( " please enter the title of the task ");

            string title=Console.ReadLine();

            tasks[taskIndex] = title;

            Console.WriteLine( " task added ");

            taskIndex++;
        }
        public static void ViewTask()
        {
            Console.WriteLine( " task list :");
            for (int i = 0; i<taskIndex; i++)
            {
                Console.WriteLine( $"{i+1}. task title {tasks[i]}");
            }
        }
        public static void CompleteTask()
        {
            Console.WriteLine( " enter task number" );
            int tasknumber=int.Parse( Console.ReadLine() );
            tasks[tasknumber] = tasknumber + " COMPLETED ";
        }
        public static void RemoveTask()
        {

            Console.WriteLine(" enter task number to remove ");
            int tasknumber = int.Parse(Console.ReadLine());
            tasks[tasknumber] = string.Empty;
        }
    }
}
