using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest1
{
    [TestClass]
    public class AddMethodTests
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
            int anynumber = 1;
            int expected;
            int actual;

            //act
            expected = 1;
            customlist.Add(1);
            customlist.Add(2);
            customlist.Add(3);
            customlist.Add(4);
            customlist.Add(5);
            actual = customlist[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
