using Microsoft.VisualStudio.TestTools.UnitTesting;

// Аввакумов Владимир, Сематкин Артем, Шакиров Айнур

namespace TestProjectArray1
{
    [TestClass]
    public class UnitTestArray
    {
        [TestMethod]
        public void TestGetLength()
        {
            int newLen = 4;
            DynArray array = new DynArray(newLen);
            int actLen = array.GetLength();
            Assert.AreEqual(newLen, actLen, "[eq"); 
        }
    }

    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void TestIsEmpty()
        {
            MyStack stack = new MyStack();
            MyStack stack1 = new MyStack();
            stack1.Push(1);
            stack1.Push(1);
            stack1.Push(1);
            Assert.IsTrue(stack1.IsEmpty(), "stack1 is not empty");
            Assert.IsTrue(stack.IsEmpty(), "stack is not empty");
        }
    }


}
