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
    
    }
    }