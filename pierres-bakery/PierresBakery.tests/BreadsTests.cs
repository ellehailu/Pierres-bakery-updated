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
        public void GetBreadAmount_ReturnBreadAmount_Int(){
            int breadAmount = 3;
            Bread newBread = new Bread(breadAmount);
            int expectedAmount = newBread.BreadAmount;
            Assert.AreEqual(breadAmount, expectedAmount);
        }

        [TestMethod]
        public void SetBreadAmount_SetValueOfBread_Void(){
            int breadAmount = 3;
            Bread newBread = new Bread(breadAmount);
            int updatedAmount = 7;
            newBread.BreadAmount = updatedAmount;
            Assert.AreEqual(updatedAmount, newBread.BreadAmount);
        }
    }
}



// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()