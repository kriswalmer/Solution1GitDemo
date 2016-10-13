using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.ReSharper.Psi.Resources;


namespace ConsoleApplication3
{
    public class Program
    {

        private const string TestableString = "testable String";

        private static void Main(string[] args)
       {
            Console.WriteLine(TestableString);
            var p1 = new Program();
            p1.WriteBasic();
        }

        public string testableMethod()
        {
            return TestableString;
        }

        public string WriteBasic()
        {
            return "aaa";
        }

        public Array BuildArray()
        {
            Array a = new int[10];
            a.SetValue(0, 0);
            a.SetValue(1, 1);
            a.SetValue(2, 2);
            a.SetValue(3, 3);
            a.SetValue(4, 4);
            a.SetValue(5, 5);
            return a;
        }

        public Array BuildArrayWithLinq()
        {

            Array _array = new int[10];
            for (var loopvar = 0; loopvar < 10; loopvar++)
            {
                _array.SetValue(loopvar, loopvar);

            }

            var numQuery = from basicInt in (int[]) _array
                where (basicInt%2 == 0)
                select basicInt;
            Array abc = new int[] {0, 2, 4, 6, 8, 10};
            var count = 0;
            foreach (var a in numQuery)
            {
                abc.SetValue(a, count);
                count++;
            }

            return abc;


        }

        public int SquareLambda(int x1)
        {

            // (x, y) => (x*y);
            Func<int, int> func1 = x => x*x;
            return func1(x1);
            
        }

        public int MultiplyLambda(int x, int y)
        {
            Func<int, int, int> func5 = (x1, y1) => x1*y1; 
            return func5(x ,  y ); 
        }
    }
}
