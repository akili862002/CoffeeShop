using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class BillEntity
    {
        public int order_number;
        public long customer_pay;
        public long total_price;
        public string description;
        public string created_at;

        public BillEntity setOrderNumber(int order_number)
        {
            this.order_number = order_number;
            return this;
        }

        public BillEntity setCustomerPay(long customer_pay)
        {
            this.customer_pay = customer_pay;
            return this;
        }
        public BillEntity setTotalPrice(long total_price)
        {
            this.total_price = total_price;
            return this;
        }
        public BillEntity setDescription(string desc)
        {
            this.description = desc;
            return this;
        }
    }
}
