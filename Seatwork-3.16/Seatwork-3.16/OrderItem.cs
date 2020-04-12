using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork_3._16
{
    public class OrderItem
    {
        public int orderItemID { get; set; }
        public string tradeName { get; set; }
        public int tradeNum { get; set; }
        public int pricePerTrade { get; set; }

        public OrderItem() { }
        public OrderItem(int OrderID, string TradeName, int TradeNum, int PricePerTrade = 0)
        {
            orderItemID = OrderID;
            tradeName = TradeName;
            tradeNum = TradeNum;
            pricePerTrade = PricePerTrade;
        }
        public override string ToString()
        {
            return "订单项:" + orderItemID + " 货物名:" + tradeName + " 订单总额:" + tradeNum * pricePerTrade;
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

        public OrderItem Clone()
        {
            OrderItem newOrderItem = new OrderItem();
            newOrderItem.orderItemID = this.orderItemID;
            newOrderItem.tradeName = this.tradeName;
            newOrderItem.tradeNum = this.tradeNum;
            newOrderItem.pricePerTrade = this.pricePerTrade;
            return newOrderItem;
        }
    }
}
