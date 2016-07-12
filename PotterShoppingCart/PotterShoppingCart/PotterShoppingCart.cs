using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        public PotterShoppingCart()
        {

        }

        public double CalculatePrice(List<Order> orders)
        {
            double SumPrice = 0;

            foreach (var item in orders)
            {
                SumPrice += item.Price * item.Qty;
            }

            return SumPrice;
        }
    }


    public class Order
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Qty { get; set; }
    }

    public class PotterEpisode
    {
        public string Episode1 { get; set; }

        public string Episode2 { get; set; }

        public string Episode3 { get; set; }

        public string Episode4 { get; set; }

        public string Episode5 { get; set; }
    }
}
