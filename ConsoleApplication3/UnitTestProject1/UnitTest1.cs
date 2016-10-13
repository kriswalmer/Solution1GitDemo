using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;
using Moq; 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
           Program _program;
         Array _array;
   

        [TestInitialize]
        public void TestInitialize()
        {
         _program = new Program();
          

        }

        [TestMethod]
        public void TestMethod1()
        {
            TestInitialize();
           Assert.AreEqual("aaa" ,  _program.WriteBasic()) ; 

        }

        [TestMethod]
        public void BuildArray()
        {
            Array _array = new int[10];
            _array.SetValue(0, 0);
            _array.SetValue(1, 1);
            _array.SetValue(2, 2);
            _array.SetValue(3, 3);
            _array.SetValue(4, 4);
            _array.SetValue(5, 5);
            foreach (int i  in _array)
            {
              Assert.AreEqual(_array.GetValue(i), _program.BuildArray().GetValue(i));
            }
          

        }

        [TestMethod]
        public void Test_LINQ_Query()
        {
            int[] intA = {0, 2, 4, 6, 8, 10 };
            int a = 0 ; 
            // for every Variable i in the Integer Array 
            //Assert if it is equal to the corresponding value in the build array method of program 
            foreach (var i in intA)
            {  
                Console.WriteLine(i);
                Assert.AreEqual(intA.GetValue(a) , _program.BuildArrayWithLinq().GetValue(a));
                   a++;
            }
        }

        [TestMethod]
        public void Test_SquareLambda()
        {
            TestInitialize();
            Assert.AreEqual(25 , _program.SquareLambda(5));
            Assert.AreEqual(36, _program.SquareLambda(6));
        }

        [TestMethod]
        public void MockTest()
        {
            Mock m = new Mock<Program>();
           m.Verify();
        }
        [TestMethod]
        public void Test_MultiplyLambda()
        {
            TestInitialize();
            Assert.AreEqual(20, _program.MultiplyLambda(5,4));
            Assert.AreEqual(36, _program.MultiplyLambda(3, 12 ));
            Assert.AreEqual(75, _program.MultiplyLambda(3, 25));
        }
    }
}
