
namespace CustomDataStruct.Tests.CustomStack.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CustomDataStruct;
    using System.Collections.Generic;

    [TestClass]
    public class CustomStackTests
    {
        private CustomStack<int> customStack;

        /// <summary>
        /// It is executed before each test method and initialize the object customStack
        /// </summary>
        [TestInitialize]
        public void InitCustomStack()
        {
            this.customStack = new CustomStack<int>();
        }

        [TestMethod]
        public void TestCountAfterPushingTwoTimes()
        {
            customStack.Push(5);
            customStack.Push(2);
            Assert.AreEqual(2, customStack.Count,
                "customStack.Count is not equal to 2 after pushing two elements");
        }

        [TestMethod]
        public void TestCountAfterPop()
        {
            customStack.Push(10);
            Assert.AreEqual(1, customStack.Count,
                "customStack.Count is not equal to 1 after pushing one element");

            customStack.Pop();
            Assert.AreEqual(0, customStack.Count,
            "customStack.Count is not equal to 0 after pushing one element and then pop it");
        }

        [TestMethod]
        public void TestPopOrderAfderPush()
        {
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);

            List<int> listIntegers = new List<int>();
            while (customStack.Count > 0)
            {
                var element = customStack.Pop();
                listIntegers.Add(element);
            }

            string result = string.Join(" ", listIntegers);
            Assert.AreEqual("3 2 1", result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPopWhenStackIsEmpty()
        {
            customStack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPeekWhenStackIsEmpty()
        {
            customStack.Peek();
        }

        [TestMethod]
        public void TestPushing10Elements()
        {
            for (int i = 0; i < 10; i++)
            {
                customStack.Push(i);
            }

            Assert.AreEqual(10, customStack.Count,
                "customStack.Count is not equal to 10 after pushing ten elements");
        }

        [TestMethod]
        public void ContainsShouldReturnFalseWhenElementIsMissing()
        {
            bool isFalse = customStack.Contains(5);
            //Assert.AreEqual(false, isFalse);
            Assert.IsFalse(isFalse);
        }

        [TestMethod]
        public void ContainsShouldReturnTrueWhenElementIsPresent()
        {
            customStack.Push(5);
            bool isTrue = customStack.Contains(5);
            //Assert.AreEqual(true, isTrue);
            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        [Timeout(10)]
        public void ShouldPush100ElementsUnder10Miliseconds()
        {
            for (int i = 0; i < 100; i++)
            {
                customStack.Push(i);
            }
        }
    }
}
