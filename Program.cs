namespace LearningCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintingCompany printingCompany = new PrintingCompany();

            // ✅ Multicast delegate (use += to add)
            printingCompany.CustomerChoicePrintMessage = HappyDeepali;
            printingCompany.CustomerChoicePrintMessage += Method1;
            printingCompany.CustomerChoicePrintMessage += HappyNewYear;

            printingCompany.Print("RAM");

            Console.ReadLine();
        }

        private static string Method1(string message)
        {
            return "Welcome to Delegate World ------ " + message;
        }

        private static string HappyNewYear(string message)
        {
            return "Happy new year " + message;
        }

        private static string HappyDeepali(string message)
        {
            return "Happy Depavali " + message;
        }
    }
}
