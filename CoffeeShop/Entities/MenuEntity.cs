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
        public string menu_name;
        public int created_by = Program.Global.user.id;

        public MenuEntity setId(int id)
        {
            this.id = id;
            return this;
        }
        public MenuEntity setName(string name)
        {
            this.menu_name = name;
            return this;
        }
    }
}
