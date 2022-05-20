using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class OrderItemEntity
    {
        public int order_number;
        public int product_id;
        public int quantity;
        public DateTime created_at;
        public DateTime updated_at;

        public OrderItemEntity setOrderNumber(int order_number)
        {
            this.order_number = order_number;
            return this;
        }
        public OrderItemEntity setProductId(int product_id)
        {
            this.product_id = product_id;
            return this;
        }
        public OrderItemEntity setQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }
    }
}
