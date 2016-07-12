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

            var group = orders.GroupBy(s => new { s.Name, s.Price })
                .Select(s => new
                {
                    Name = s.Key.Name,
                    Price = s.Key.Price,
                    Qty = s.Count()
                }).ToList();

            
            switch(group.Count)
            {
                case 1:
                    foreach(var item in group)
                    {
                        SumPrice += item.Price * item.Qty;
                    }
                    break;
                case 2:
                    foreach(var item in group)
                    {
                        SumPrice += item.Price * item.Qty * 0.95;
                    }
                    break;
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
        public string Episode1 { get { return "EP1"; } }

        public string Episode2 { get { return "EP2"; } }

        public string Episode3 { get { return "EP3"; } }

        public string Episode4 { get { return "EP4"; } }

        public string Episode5 { get { return "EP5"; } }
    }
}
