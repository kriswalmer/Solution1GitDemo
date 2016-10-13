using System;
namespace Class1Extension
{
    public static class Class1
    {

        public static void AddToObject(this Object obj)
        {
            Console.WriteLine("printed from main");
            }
    }
}