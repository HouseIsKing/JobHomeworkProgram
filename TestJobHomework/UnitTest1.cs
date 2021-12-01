using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobHomeworkProgram;
using System.Collections.Generic;

namespace TestJobHomework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            List<int>? result = Program.GetFibonachiList(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(arr[i], result[i]);
            }
            arr = new int[]{ 1 };
            Assert.AreEqual(arr[0], Program.GetFibonachiList(arr.Length)[0]);
            Assert.AreEqual(null, Program.GetFibonachiList(-3));
        }
    }
}