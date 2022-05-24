using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class OrderEntity
    {
        public int order_number;
        public string description;
        public int table_id;
        public int buyer_id = Program.Global.user.id;
        public DateTime created_at;

        public OrderEntity setOrderNumber(int order_number)
        {
            this.order_number = order_number;
            return this;
        }

        public OrderEntity setDescription(string desc)
        {
            this.description = desc;
            return this;
        }
        public OrderEntity setTableItd(int table_id)
        {
            this.table_id = table_id;
            return this;
        }
        public OrderEntity setBuyerId(int buyer_id)
        {
            this.buyer_id = buyer_id;
            return this;
        }
    }
}
