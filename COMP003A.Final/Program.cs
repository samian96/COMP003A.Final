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
            Console.Write("1. Create Character: \n 2. View All Characters: \n 3: View Character Stats: \n Remove Character: \n Exit Program.");
        }
    }
}
