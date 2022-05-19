using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class MenuEntity
    {
        public int id;
        public int created_by;
        public string menu_name;

        public MenuEntity setId(int id)
        {
            this.id = id;
            return this;
        }
        public MenuEntity setCreatedBy(int created_by)
        {
            this.created_by = created_by;
            return this;
        }
        public MenuEntity setName(string name)
        {
            this.menu_name = name;
            return this;
        }
    }
}
