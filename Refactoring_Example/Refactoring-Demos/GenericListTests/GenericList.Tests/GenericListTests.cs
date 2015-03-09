using System;
using GenericList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericListTests.GenericList.Tests
{
    [TestClass]
    public class GenericListTests
    {
        private GenericList<int> list;

        [TestInitialize]
        public void InitGenericList()
        {
            this.list = new GenericList<int>();
        }

        [TestMethod]
        public void TestAddElementToList()
        {
            this.list.Add(5);
            Assert.AreEqual(5, this.list[0]);
        }

        [TestMethod]
        public void TestCountAddingElementOverCapacity()
        {
            this.list = new GenericList<int>(2);
            for (int i = 0; i < 5; i++)
            {
                this.list.Add(i);
            }

            Assert.AreEqual(5, this.list.Count);
        }

        [TestMethod]
        public void TestInsertAtPosition2()
        {
            for (int i = 0; i < 3; i++)
            {
                this.list.Add(i);
            }

            this.list.InsertAt(20, 2);
            Assert.AreEqual(20, this.list[2]);
            Assert.AreEqual(2, this.list[3]);
        }

        [TestMethod]
        public void TestRemoveElement()
        {
            for (int i = 0; i < 5; i++)
            {
                this.list.Add(i);
            }

            Assert.AreEqual(3, this.list[3]);
            this.list.Remove(3);
            Assert.AreEqual(4, this.list[3]);
        }

        [TestMethod]
        public void TestIfClearMethodClearsList()
        {
            for (int i = 0; i < 5; i++)
            {
                this.list.Add(i);
            }

            this.list.Clear();
            Assert.AreEqual(0, this.list.Count);
        }

        [TestMethod]
        public void TestIfFindMethodGetIndexOfElementInOrderedList()
        {
            for (int i = 0; i < 5; i++)
            {
                this.list.Add(i);
            }

            var foundIndex = this.list.Find(4);
            Assert.AreEqual(4, foundIndex);
        }

        [TestMethod]
        public void TestIfFindMethodGetIndexOfExistingElementInUnorderedList()
        {
            this.list.Add(4);
            this.list.Add(2);
            this.list.Add(1);
            this.list.Add(7);

            var foundIndex = this.list.Find(4);
            Assert.AreEqual(0, foundIndex);
        }

        [TestMethod]
        public void TestIfFindMethodGetIndexOfNotExistingElementInUnorderedList()
        {
            this.list.Add(4);
            this.list.Add(2);
            this.list.Add(1);
            this.list.Add(7);

            var foundIndex = this.list.Find(10);
            Assert.AreEqual(-1, foundIndex);
        }

        [TestMethod]
        public void TestIfMaxMethodReturnsMaxIntValueInListOfInt()
        {
            this.list.Add(4);
            this.list.Add(2);
            this.list.Add(1);
            this.list.Add(27);
            this.list.Add(7);

            var maxIntValue = this.list.Max();
            Assert.AreEqual(27, maxIntValue);
        }

        [TestMethod]
        public void TestIfMinMethodReturnsMinIntValueInListOfInt()
        {
            this.list.Add(4);
            this.list.Add(2);
            this.list.Add(1);
            this.list.Add(27);
            this.list.Add(7);

            var minIntValue = this.list.Min();
            Assert.AreEqual(1, minIntValue);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestIndexingListCount()
        {
            for (int i = 0; i < 5 ; i++)
            {
                this.list.Add(i);
            }

            var val = this.list[5];
        }
    }
}
