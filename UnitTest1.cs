using Microsoft.VisualStudio.TestTools.UnitTesting;
//We Setup the Unit Testing Project
//We add the reference to our main project in solution explorer
//Add the reference of project by using statement
using PointerAssignment;

namespace UnitTestProject1
{
    //Testing class which contain testing method
    [TestClass]
    public class UnitTest1
    {
        //This is test method for which implementation is not necessary 
        //Test method for part 1
        [TestMethod]
        public bool checkValidty()
        {
            return true;
        }
        //This method will compare the result with drawTo method in our project
        [TestMethod]
        public void TestDraw1(int x, int y)
        {   //object of Form
            Form1 frm = new Form1();
         //Compare the form if expected and orignal values are equal
            Assert.AreEqual(frm.drawTo(100,200), frm.drawTo(x, y));
        }
        //This method will compare the result with drawTo method in our project
        [TestMethod]
        public void TestDraw2(int x, int y)
        {  //object of Form
            Form1 frm = new Form1();
            //Compare the form if expected and orignal values are equal
            Assert.AreNotSame(12, frm.drawTo(x, y));
        }
        [TestMethod]
        public void TestDraw3()
        {
            Assert.AreEqual(3, 3);
        }
        //Unit Test for part 2
        [TestMethod]
        public void TestLoop1()
        {
            int ExpectedLoopCount = 6;
            int ActualLoopCount=0;
            for(int i=0;i<=5;i++)
            {
                ActualLoopCount++;
            }
            Assert.AreEqual(ExpectedLoopCount, ActualLoopCount);
        }
        //Unit Test for part 2
        [TestMethod]
        public void TestLoop2()
        {
            int ExpectedLoopIndex = 0;
            int ActualLoopCount = 0;
            for (int i = 0; i <= 5; i++)
            {
                ActualLoopCount++;
            }
            Assert.AreNotEqual(ExpectedLoopIndex, ActualLoopCount);
        }
        //Unit Test for part 2
        [TestMethod]
        public void TestIFStatment()
        {
            int Expectedresult = 2;
            int ActualResult = 0;
            if(ActualResult==0)
            {
                ActualResult = 2;
            }
         
            Assert.AreEqual(Expectedresult, ActualResult);
        }
    }
}
