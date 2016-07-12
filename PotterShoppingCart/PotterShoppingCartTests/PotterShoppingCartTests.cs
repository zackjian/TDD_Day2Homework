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
            var actual = target.CalculatePrice(orders);

            //assert
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }
    }
}