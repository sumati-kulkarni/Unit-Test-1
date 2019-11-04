using System;
using System.Diagnostics;
using Unit_Test__1.Model;
using Unit_Test__1.Model.Impl;

namespace Unit_Test__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Item firstItem = new ItemImpl(1, "First Item", UnitOfMeasure.POUND, 10);
            Debug.WriteLine(firstItem);
            Console.WriteLine(firstItem);

            //keeps console open for viewing purposes, press any key to exit
            Console.ReadLine();
        }
    }
}
