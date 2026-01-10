using System;

namespace MultiCastDelegate
{
    public class Program
    {
        // 1) Delegate
        public delegate void MyDelegate(string msg);

        // 2) Methods
        static void MethodA(string msg) => Console.WriteLine("A: " + msg);
        static void MethodB(string msg) => Console.WriteLine("B: " + msg);
        static void MethodC(string msg) => Console.WriteLine("C: " + msg);

        static void Main()
        {
            //int x = 10;
            //x += 1;

            // 3) Multicast delegate (combine methods)
            MyDelegate d = MethodA;
            d += MethodB;
            d += MethodC;

            // 4) Invoke (calls all methods)
            d("Hello");

            Console.ReadLine();
        }
    }
}
