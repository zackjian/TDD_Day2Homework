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
            var _orders = orders;

            while ((_orders.Where(s => s.Qty > 0).Count() > 0 ? true : false))
            {
                double groupPrice = 0;

                var group = orders.GroupBy(s => new { s.Name, s.Price, s.Qty })
                .Select(s => new
                {
                    Name = s.Key.Name,
                    Price = s.Key.Price,
                    Qty = s.Sum(b => b.Qty)
                }).Where(s => s.Qty > 0).ToList();

                foreach (var item in group)
                {
                    groupPrice += item.Price * 1;
                }

                switch (group.Count)
                {
                    case 1:                        
                        break;
                    case 2:
                        groupPrice *= 0.95;
                        break;
                    case 3:
                        groupPrice *= 0.9;
                        break;
                    case 4:
                        groupPrice *= 0.8;
                        break;
                    case 5:
                        groupPrice *= 0.75;
                        break;
                }

                //將計算過的扣掉
                foreach (var order in orders)
                {
                    order.Qty = order.Qty - 1;
                }

                SumPrice += groupPrice;
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
