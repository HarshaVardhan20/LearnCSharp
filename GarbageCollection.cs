
using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        List<object> list = new List<object>();

        for (int i = 0; i < 20000; i++)
            list.Add(new byte[1024]); // many allocations

        Console.WriteLine("Allocated");
        Console.WriteLine("Total memory: " + GC.GetTotalMemory(forceFullCollection: false));
    }
}

