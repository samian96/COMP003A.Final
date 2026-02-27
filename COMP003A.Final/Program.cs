namespace COMP003A.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            MenuDisplay();

            while (running)
            {
                Console.ReadLine();
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
