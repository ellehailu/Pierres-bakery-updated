using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
    [TestClass]

    public class PastriesTests
    {
        [TestMethod]
        public void PastriesConstructor_CreatesPastriesObject_PastriesObject()
        {
            int PastriesAmount = 3;
            Pastries newPastries = new Pastries(PastriesAmount);
            Assert.AreEqual(typeof(Pastries), newPastries.GetType());
        }

        [TestMethod]
        public void GetPastries_ReturnPastriesAmount_Int(){
            int pastriesAmount = 3;
            Pastries newPastries = new Pastries(pastriesAmount);
            int expectedAmount = newPastries.PastriesAmount;
            Assert.AreEqual(pastriesAmount, expectedAmount);
        }
    }
    }