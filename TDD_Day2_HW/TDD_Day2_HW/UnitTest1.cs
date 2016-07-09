using Book;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;

namespace TDD_Day2_HW
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Buy_1_The_First_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
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

        [TestMethod]
        public void Buy_1_The_First_And_Second_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
                Second = 1,
                Third = 0,
                Fourth = 0,
                Fifth = 0
            };
            int expect = 190;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_1_The_First_And_Second_And_Third_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
                Second = 1,
                Third = 1,
                Fourth = 0,
                Fifth = 0
            };
            int expect = 270;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_1_The_First_And_Second_And_Third_And_Fourth_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
                Second = 1,
                Third = 1,
                Fourth = 1,
                Fifth = 0
            };
            int expect = 320;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_1_The_First_And_Second_And_Third_And_Fourth_And_Fifth_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
                Second = 1,
                Third = 1,
                Fourth = 1,
                Fifth = 1
            };
            int expect = 375;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_1_The_First_And_Second_Buy_2_The_Third_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
                Second = 1,
                Third = 2,
                Fourth = 0,
                Fifth = 0
            };
            int expect = 370;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Buy_1_The_First_Buy_2_The_Second_And_Third_Potter()
        {
            //Arrage
            var order = new Potter
            {
                First = 1,
                Second = 2,
                Third = 2,
                Fourth = 0,
                Fifth = 0
            };
            int expect = 460;

            //Act
            Calculater target = new Calculater();
            int actual = target.Sum(order);

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}