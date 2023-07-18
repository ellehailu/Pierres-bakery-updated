using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]

    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesBreadObject_BreadObject()
        {
            int breadAmount = 3;
            Bread newBread = new Bread(breadAmount);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetBreadAmount_ReturnBreadAmount_Int()
        {
            int breadAmount = 3;
            Bread newBread = new Bread(breadAmount);
            int expectedAmount = newBread.BreadAmount;
            Assert.AreEqual(breadAmount, expectedAmount);
        }

        [TestMethod]
        public void SetBreadAmount_SetAmountOfBread_Void()
        {
            int breadAmount = 3;
            Bread newBread = new Bread(breadAmount);
            int updatedAmount = 7;
            newBread.BreadAmount = updatedAmount;
            Assert.AreEqual(updatedAmount, newBread.BreadAmount);
        }

        [TestMethod]
        public void CalculateBreadPrice_CalculatePriceOfBread_Int()
        {
            int breadAmount = 7;
            Bread newBread = new Bread(breadAmount);
            int price = newBread.CalculateBreadPrice();
            Assert.AreEqual(25, price);
        }
    }
}



// // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()