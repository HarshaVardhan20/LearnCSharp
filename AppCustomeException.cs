using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class AppCustomException : Exception
    {
        

        public override string Message => HandleBase(base.Message) ;

        private string HandleBase(string sysMessage)
        {
            //Oringinal Message from base class
            Console.WriteLine(sysMessage);

            return "Internal Exception Occurred. Please contact Admin.";
        }

        
    }
}
