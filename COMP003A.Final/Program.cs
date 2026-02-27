namespace COMP003A.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {
                MenuDisplay();
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Create Character Selected.");
                        break;
                    case "2":
                        Console.WriteLine("View all characters selected.");
                        break;
                    case "3":
                        Console.WriteLine("View Character Stats Selected.");
                        break;
                    case "4":
                        Console.WriteLine("Remove Character Selected.");
                        break;
                    case "5":
                        Console.WriteLine("Exiting Program.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
        }
        static void MenuDisplay()
        {
            Console.WriteLine("Character Creation Menu:");
            Console.WriteLine("1. Create Character: \n2. View All Characters: \n3: View Character Stats: \nRemove Character: \nExit Program:");
            Console.Write("Choose an option: ");
        }
    }
}
