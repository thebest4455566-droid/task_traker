namespace task_traker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static string[]description= new string[100];
        static string[]duedates= new string[100];
        static string[]priorities = new string[100];
        static string[]status= new string[100];


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

            Console.WriteLine( " please enter the description");
            description[taskIndex] = Console.ReadLine();

            Console.WriteLine( " please enter the due date ");
            duedates[taskIndex] = Console.ReadLine();

            Console.WriteLine( " please enter the priority : higth / medium / low ");
            priorities[taskIndex] = Console.ReadLine();

            status[taskIndex] = "pending";

            Console.WriteLine( " task added ");

            taskIndex++;
        }
        public static void ViewTask()
        {
            Console.WriteLine( " task list :");
            for (int i = 0; i<taskIndex; i++)
            {
                Console.WriteLine( $"{i+1}. task title {tasks[i]} | descripion {description[i]} | due date {duedates[i]} | priority {priorities[i]} | status {status[i]}");
            }
        }
        public static void CompleteTask()
        {

            if (taskIndex == 0)
            {
                Console.WriteLine(" no task yet ");
                return;
            }
            Console.WriteLine( " enter task number" );
            int tasknumber;
            if(!int.TryParse( Console.ReadLine(), out tasknumber))
            {
                Console.WriteLine( " invalid number ");
                return;
            }
            status[tasknumber - 1] = "completed";
            Console.WriteLine( "task marked as completed ");
        }
        public static void RemoveTask()
        {
            if( taskIndex==0)
            {
                Console.WriteLine( " no task yet ");
                return;
            }

            Console.WriteLine(" enter task number to remove ");
            int tasknumber;
            if(!int.TryParse( Console.ReadLine(), out tasknumber))
            {
                Console.WriteLine( " invalid number ");
                return;
            }
            for(int i=tasknumber-1;i<taskIndex;i++)
            {
                tasks[i] = tasks[i + 1];
                description[i]=description[i+1];
                duedates[i] = duedates[i+1];
                priorities[i] = priorities[i+1];
                status[i] = status[i+1];
            }
            Console.WriteLine( " the task makrked as deleted ");
            taskIndex--;
        }
    }
}
