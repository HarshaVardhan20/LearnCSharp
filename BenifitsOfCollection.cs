using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class BenifitsOfCollection
    {
        public void CollectData()
        {
            List<int> ints = new List<int>();
            

            var greaterThan5 =ints.Select(n => n > 5);

            var processes = from p in System.Diagnostics.Process.GetProcesses() select p.ProcessName;

            foreach (var item in processes)
            {
                Console.WriteLine(item);
            }


        }
    }
}
