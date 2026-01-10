using System;

namespace LearningCSharp
{
    // Delegate (matches your methods)
    public delegate string PrintMessage(string message);

    public class PrintingCompany
    {
        public PrintMessage? CustomerChoicePrintMessage;

        public void Print(string name)
        {
            if (CustomerChoicePrintMessage == null)
            {
                Console.WriteLine("No message methods attached!");
                return;
            }

            // ✅ Print output of ALL methods using invocation list
            foreach (var del in CustomerChoicePrintMessage.GetInvocationList())
            {
                var method = (PrintMessage)del;
                string result = method(name);
                Console.WriteLine(result);
            }
        }
    }
}
