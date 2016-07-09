using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD_Day2_HW
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Buy_1_the_first_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 0,
                Second = 0,
                Third = 0,
                Fourth = 0,
                Fifth = 0
            };
            int expect = 100;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}