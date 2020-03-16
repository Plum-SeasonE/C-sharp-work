using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork_3._16
{
    class OrderItem
    {
        public int orderItemID { get; set; }
        public string tradeName { get; set; }
        public string employee { get; set; }
        public string custom { get; set; }
        public int tradeNum { get; set; }
        public int pricePerTrade { get; set; }
        public OrderItem(int OrderID, string TradeName, string Empoylee,
            string Custom, int TradeNum, int PricePerTrade = 0)
        {
            orderItemID = OrderID;
            tradeName = TradeName;
            employee = Empoylee;
            custom = Custom;
            tradeNum = TradeNum;
            pricePerTrade = PricePerTrade;
        }
        public override string ToString()
        {
            return "订单号:" + orderItemID + " 货物名:" + tradeName +"发货人:"+employee
                +"订货人:"+custom+ " 订单总额:" + tradeNum * pricePerTrade;
        }
        public override bool Equals(object obj)
        {
            OrderItem oi = obj as OrderItem;
            return orderItemID == oi.orderItemID;
        }
        public override int GetHashCode()
        {
            return orderItemID;
        }
     
    }
}
