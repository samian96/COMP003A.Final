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
                string userInput = Console.ReadLine()?.Trim(); ;

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Create Character Selected.");
                        Case1();
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
        static void Case1()
        {
            Console.Clear();
            Console.WriteLine("Creating New Character");

            Console.Write("Please enter your characters name: ");
            string charName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(charName))
            {
                Console.WriteLine("Invalid name, name requires one character, returning to menu.");
                return;
            }
            Console.WriteLine("\nChoose a class:");
            Console.WriteLine("1. Fighter");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Stealth");
            Console.Write("Please Enter Class Number: ");

            string charChoice = Console.ReadLine()?.Trim();

            string charClasses; 

            switch (charChoice)
            {
                case "1":
                    charClasses = "Fighter";
                    break;
                case "2":
                    charClasses = "Mage";
                    break;
                case "3":
                    charClasses = "Stealth";
                    break;
                default:
                    Console.WriteLine("\n Invalid choice. Please try again.");
                    Console.ReadLine();
                    return;
            }
            // success path
            Console.WriteLine("\n Character created.");
            Console.WriteLine($"Name: {charName}\nClass: {charClasses}");

            Console.WriteLine("Press enter to return to menu...");
            Console.ReadLine();

        }
    }
}
