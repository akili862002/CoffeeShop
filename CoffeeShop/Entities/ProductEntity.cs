using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class ProductEntity
    {
        public int id;
        public string name;
        public string picture;
        public long profit;
        public long price;
        public int stock;
        public string unit;
        public int menu_id;
        public int created_by = Program.Global.user.id;
        public DateTime created_at;
        public DateTime updated_at;

        // Exotic Database
        public string menu_name;

        public ProductEntity setId(int id)
        {
            this.id = id;
            return this;
        }
        public ProductEntity setName(string name)
        {
            this.name = name;
            return this;
        }
        public ProductEntity setPicture(string picture)
        {
            this.picture = picture;
            return this;
        }
        public ProductEntity setPrice(long price)
        {
            this.price = price;
            return this;
        }

        public ProductEntity setProfit(long profit)
        {
            this.profit = profit;
            return this;
        }

        public ProductEntity setStock(int stock)
        {
            this.stock = stock;
            return this;
        }

        public ProductEntity setUnit(string unit)
        {
            this.unit = unit;
            return this;
        }
        public ProductEntity setMenuId(int menu_id)
        {
            this.menu_id = menu_id;
            return this;
        }

        public ProductEntity setMenuName(string menu_name)
        {
            this.menu_name = menu_name;
            return this;
        }
    }
}
