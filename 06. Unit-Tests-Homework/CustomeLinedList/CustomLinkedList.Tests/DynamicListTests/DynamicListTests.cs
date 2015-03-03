
namespace CustomLinkedList.Tests.DinamicListTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CustomLinkedList;

    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<int> emptyList;

        [TestInitialize]
        public void InitDynamicList()
        {
            this.emptyList = new DynamicList<int>();
        }

        [TestMethod]
        public void TestCountEqualToZeroWhenCreateEmtyDynamicList()
        {
            Assert.AreEqual(0, emptyList.Count,
                "Count of empty DynamicList is not equal to zero.");
        }

        [TestMethod]
        public void TestAddElementInDynamicList()
        {
            this.emptyList.Add(1);
            Assert.AreEqual(1, this.emptyList[0], 
                "First element in DynamicList is not equal to added element 1.");
        }

        [TestMethod]
        public void TestCountEqualToOneWhenDynamicListAddOneElement()
        {
            this.emptyList.Add(1);
            Assert.AreEqual(1, emptyList.Count,
                "Count of DynamicList after Add(1) is not equal to 1.");
        }

        [TestMethod]
        public void TestAddElementAtSomeValidIndex()
        {
            this.emptyList.Add(5);
            this.emptyList[0] = 1;
            Assert.AreEqual(1, this.emptyList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddElementAtIncorrectIndexOfDynamicList()
        {
            this.emptyList.Add(5);
            this.emptyList[1] = 1;
            Assert.AreEqual(1, this.emptyList[1]);
        }

        [TestMethod]
        public void TestContainsElementInDynamiListReturnTrue()
        {
            this.emptyList.Add(1);
            bool isTrue = this.emptyList.Contains(1);
            Assert.IsTrue(isTrue, 
                "DynamicList does not contains added element 1.");
        }

        [TestMethod]
        public void TestContainsElementInDynamiListReturnFalse()
        {
            this.emptyList.Add(1);
            bool isFalse = this.emptyList.Contains(10);
            Assert.IsFalse(isFalse, 
                "DynamicList contains element 10.");
        }

        [TestMethod]
        public void TestIndexOfExistingElementInDynamicList()
        {
            this.emptyList.Add(1);
            this.emptyList.Add(2);
            Assert.AreEqual(0, emptyList.IndexOf(1),
                "Incorrect index.Index of element 1 is not found.");
            Assert.AreEqual(1, emptyList.IndexOf(2),
                "Incorrect index.Index of element 2 is not found.");
        }

        [TestMethod]
        public void TestIndexOfElementWhenItDoesNotExist()
        {
            this.emptyList.Add(1);
            Assert.AreEqual(-1, emptyList.IndexOf(2),
                "Index exists.");
        }

        [TestMethod]
        public void TestRemoveExistingElementOfDynamicList()
        {
            this.emptyList.Add(1);
            Assert.AreEqual(1, this.emptyList.Count);
            this.emptyList.Remove(1);
            Assert.AreEqual(0, this.emptyList.Count, 
                "Added element does not removed.");
        }

        [TestMethod]
        public void TestRemoveElementInEmptyDynamicList()
        {
            var result = this.emptyList.Remove(1);
            Assert.AreEqual(-1, result, 
                "DynamicList is not empty.");
        }

        [TestMethod]
        public void TestRemoveElementAtIndexOfDynamicList()
        {
            this.emptyList.Add(1);
            Assert.AreEqual(1, this.emptyList.Count);
            this.emptyList.RemoveAt(0);
            Assert.AreEqual(0, this.emptyList.Count,
                "Added element does not removed.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexIfLessThanZero()
        {
            var indexOutOfRange = this.emptyList[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexIfGreaterThanDynamicListCount()
        {
            var indexOutOfRange = this.emptyList[this.emptyList.Count];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtIndexLessThanZeroOfDynamicList()
        {
            var incorrectIndexLessThanZero = this.emptyList.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtIndexGreaterThanDynamicListCount()
        {
            var incorrectIndexGreaterThanDynamicListCount =
                this.emptyList.RemoveAt(this.emptyList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveElementAtIndexInEmptyDynamicList()
        {
            var resultException = this.emptyList.RemoveAt(0);
        }
    }
}
