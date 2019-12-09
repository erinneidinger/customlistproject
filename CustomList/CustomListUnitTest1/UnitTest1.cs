using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest1
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void AddMethod_AddingToIndex_ReturnIndexLocation()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            customlist.Add(expected);
            actual = customlist[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_FindCount_ReturnArrayCount()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int anynumber = 1;
            int expected;
            int actual;

            //act
            expected = 1;
            customlist.Add(anynumber);
            actual = customlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_FindCapacity_ReturnNewCapacity()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int anynumber = 1;
            int expected;
            int actual;

            //act
            expected = 4;
            customlist.Add(anynumber);
            actual = customlist.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_FindingCapacity_ReturnCapacity()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int anynumber = 1;
            bool expected = true;
            bool actual;

            //act
            customlist.Add(anynumber);
            customlist.Add(anynumber);
            customlist.Add(anynumber);
            customlist.Add(anynumber);
            customlist.Add(anynumber);
            actual = (customlist.Capacity == 8);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_FindCount_ReturningCount()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected;
            int actual;

            //act
            expected = 5;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Add(5);
            actual = customlist[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_RemoveIndex_ReturnIndex()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int actual;

            //act
            int expected = 2;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Remove(4);
            customlist.Remove(3);
            actual = customlist[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_FindCount_ReturnTotal()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected;
            int actual;

            //act
            expected = 3;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Remove(4);
            actual = customlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_FindCapacity_ReturnCapacity()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected;
            int actual;

            //act
            expected = 4;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Remove(4);
            actual = customlist.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_FindDoubleCapacity_ReturnCapacity()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected;
            int actual;

            //act
            expected = 8;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Add(5);
            customlist.Add(6);
            customlist.Add(7);
            customlist.Remove(7);
            actual = customlist.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_FindCount_ReturningCount()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected;
            int actual;

            //act
            expected = 6;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Add(5);
            customlist.Add(6);
            customlist.Add(7);
            customlist.Add(8);
            customlist.Remove(8);
            customlist.Remove(7);
            actual = customlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_FindCountWithSameNumbers_ReturningCount()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int fixednumber = 2;
            int expected;
            int actual;

            //act
            expected = 3;
            customlist.Add(fixednumber);
            customlist.Add(fixednumber);
            customlist.Add(fixednumber);
            customlist.Add(fixednumber);
            customlist.Remove(2);
            actual = customlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_FindCountWithNumberNotExisting_ReturningCount()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int expected;
            int actual;

            //act
            expected = 2;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Remove(40);
            actual = customlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
