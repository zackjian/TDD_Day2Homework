using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void Test_Fisrt_Episode_Buy_1_Other_Episode_Not_Buy_Price_Should_Be_100_Multiply_1_Equal_100()
        {
            var potterEpisode = new PotterEpisode();

            //arrange
            var target = new PotterShoppingCart();
            var orders = new List<Order>
            {
                new Order { Name=potterEpisode.Episode1, Price=100, Qty=1 }
            };

            //act
            double actual = target.CalculatePrice(orders);

            //assert
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_Fisrt_Episode_Buy_1_Second_Episode_Buy_1_Other_Episode_Not_Buy_Price_Should_Be_100_Multiply_2_Multiply_Dot95_Equal_190()
        {
            var potterEpisode = new PotterEpisode();

            //arrange
            var target = new PotterShoppingCart();
            var orders = new List<Order>
            {
                new Order { Name= potterEpisode.Episode1, Price=100, Qty=1 },
                new Order { Name= potterEpisode.Episode2, Price=100, Qty=1 }
            };

            //act
            double actual = target.CalculatePrice(orders);

            //assert
            var expected = 190;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Test_Fisrt_Episode_Buy_1_Second_Episode_Buy_1_Third_Episode_Buy_1_Other_Episode_Not_Buy_Price_Should_Be_100_Multiply_3_Multiply_Dot9_Equal_270()
        {
            var potterEpisode = new PotterEpisode();

            //arrange
            var target = new PotterShoppingCart();
            var orders = new List<Order>
            {
                new Order { Name= potterEpisode.Episode1, Price=100, Qty=1 },
                new Order { Name= potterEpisode.Episode2, Price=100, Qty=1 },
                new Order { Name= potterEpisode.Episode3, Price=100, Qty=1 }
            };

            //act 
            double actual = target.CalculatePrice(orders);

            //assert
            var expected = 270;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Test_Fisrt_Episode_Buy_1_Second_Episode_Buy_1_Third_Episode_Buy_1_Fourth_Episode_Buy_1_Other_Episode_Not_Buy_Price_Should_Be_100_Multiply_4_Multiply_Dot8_Equal_320()
        {
            var potterEpisode = new PotterEpisode();

            //arrange
            var target = new PotterShoppingCart();
            var orders = new List<Order>
            {
                new Order { Name= potterEpisode.Episode1, Price=100, Qty=1 },
                new Order { Name= potterEpisode.Episode2, Price=100, Qty=1 },
                new Order { Name= potterEpisode.Episode3, Price=100, Qty=1 },
                new Order { Name= potterEpisode.Episode4, Price=100, Qty=1 }
            };

            //act 
            double actual = target.CalculatePrice(orders);

            //assert
            var expected = 320;

            Assert.AreEqual(expected, actual);
        }

    }
}