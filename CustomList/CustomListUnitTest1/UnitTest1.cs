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

        [TestMethod]
        public void ToStringMethod_ConcatString_ReturningFullString()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            int firstnumber = 2;
            int secondnumber = 4;
            string expected = "24";

            customlist.Add(firstnumber);
            customlist.Add(secondnumber);

            string actual;

            //act
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMethod_CountingStrings_ReturnCount()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string aaron = "Aaron";
            string rodgers = "Rodgers";
            string expected = "AaronRodgers";
            string actual;

            customlist.Add(aaron);
            customlist.Add(rodgers);

            //act
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMethod_EmptyString_ReturnEmpty()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            string empty = " ";
            string expected = " ";
            string actual;

            customlist.Add(empty);

            //act
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMethod_PlusOperator_ReturnAddingLists()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";
            string sixthnumber = "6";

            string expectedone = "1";
            string expectedtwo = "5";
            string actualone;
            string actualtwo;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);

            //act
            customlist = one + two;
            actualone = customlist[0];
            actualtwo = customlist[4];

            //assert
            Assert.AreEqual(expectedone, actualone);
            Assert.AreEqual(expectedtwo, actualtwo);
        }
        [TestMethod] //Try tests that have different amount of lists and spaces in it. 
        public void OverloadMethod_PlusOperator_AddingTwoDifferentLists()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";

            string expectedone = "2";
            string expectedtwo = "4";
            string actualone;
            string actualtwo;

            one.Add(onenumber);
            one.Add(twonumber);
            two.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);

            customlist.ToString();

            //act
            customlist = one + two;
            actualone = customlist[1];
            actualtwo = customlist[3];

            //assert
            Assert.AreEqual(expectedone, actualone);
            Assert.AreEqual(expectedtwo, actualtwo);
        }

        [TestMethod] 
        public void OverloadMethod_PlusOperator_EmptyStrings()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = " ";
            string fournumber = "4";

            string expected = " ";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            two.Add(threenumber);
            two.Add(fournumber);

            one.ToString();
            two.ToString();

            //act
            customlist = one + two;
            actual = customlist[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //Look for count and single asserts. 
        public void OverloadMethod_PlusOperator_Count()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";

            int expected = 5;
            int actual;

            one.Add(onenumber);
            one.Add(twonumber);
            two.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);

            customlist.ToString();

            //act
            customlist = one + two;
            actual = customlist.Count;
            

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMethod_MinusOperator_ReturnNewSumInLists()
        {
            //arrange
            CustomList<int> customlist = new CustomList<int>();
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            int onenumber = 1;
            int twonumber = 2;
            int threenumber = 3;
            int fournumber = 2;
            int fifthnumber = 5;
            int sixthnumber = 6;

            string actual;
            string expected;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);


            //act
            customlist = one - two;
            actual = customlist.ToString();
            expected = "13";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMethod_MinusOperator_Count()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "5";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";

            int expected = 2;
            int actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);

            customlist.ToString();

            //act
            customlist = one - two;
            actual = customlist.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMethod_MinusOperator_EmptyStrings()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = " ";
            string twonumber = "1";
            string threenumber = "1";
            string fournumber = "4";

            string expected = " ";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            two.Add(threenumber);
            two.Add(fournumber);

            one.ToString();
            two.ToString();

            //act
            customlist = one - two;
            actual = customlist[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void OverloadMethod_MinusOperator_DeterminingWhenNoChange()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";

            string expected = "12";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            two.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);

            //act
            customlist = one - two;
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ZipMethod_ZipTwoLists_DetermineSum()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";
            string sixthnumber = "6";

            string expected = "142536";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);

            //act
            customlist = one.Zip(two);
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_ZipTwoLists_EmptyString()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = " ";
            string fournumber = "4";
            string fifthnumber = "5";
            string sixthnumber = "6";

            string expected = "1425 6";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);

            //act
            customlist = one.Zip(two);
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_ZipTwoLists_Count()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber ="3";
            string fournumber = "4";
            string fifthnumber = "5";
            string sixthnumber = "6";

            int expected = 6;
            int actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);

            //act
            customlist = one.Zip(two);
            actual = customlist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_ZipTwoLists_ListWithNothing()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "";
            string fifthnumber = "";
            string sixthnumber = "";

            string expected = "123";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);

            //act
            customlist = one.Zip(two);
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_ZipTwoLists_ListTwoLongerThanOther()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";
            string sixthnumber = "6";
            string seventhnumber = "7";

            string expected = "1425367";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            two.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);
            two.Add(seventhnumber);

            //act
            customlist = one.Zip(two);
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipMethod_ZipTwoLists_ListOneLongerThanOther()
        {
            //arrange
            CustomList<string> customlist = new CustomList<string>();
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            string onenumber = "1";
            string twonumber = "2";
            string threenumber = "3";
            string fournumber = "4";
            string fifthnumber = "5";
            string sixthnumber = "6";
            string seventhnumber = "7";

            string expected = "1526374";
            string actual;

            one.Add(onenumber);
            one.Add(twonumber);
            one.Add(threenumber);
            one.Add(fournumber);
            two.Add(fifthnumber);
            two.Add(sixthnumber);
            two.Add(seventhnumber);

            //act
            customlist = one.Zip(two);
            actual = customlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
