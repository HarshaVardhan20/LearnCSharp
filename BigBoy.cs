using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class BigBoy :IDisposable
    {

        public BigBoy()
        {
            
        }
        public  ArrayList   Names { get; set; }

        public void Dispose()
        {
            Names = null;
        }

        ~BigBoy()
        {
            Names = null;

        }
    }
}
