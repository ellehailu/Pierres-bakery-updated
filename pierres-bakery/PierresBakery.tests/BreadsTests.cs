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
    }
}



// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()