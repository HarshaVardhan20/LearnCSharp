using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class AppCustomException : Exception
    {
        public override string Message => "Internal Exception";
    }
}
