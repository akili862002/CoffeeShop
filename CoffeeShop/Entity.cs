using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Table
    {
        public int table_id;
        public bool is_busy; 
        public string name; 
        public string description; 

        public Table setTableId(int table_id)
        {
            this.table_id = table_id;
            return this;
        }
        public Table setIsBusy(bool is_busy)
        {
            this.is_busy = is_busy;
            return this;
        }
        public Table setName(string name)
        {
            this.name = name;
            return this;
        }
        public Table setDescription(string description)
        {
            this.description = description;
            return this;
        }
    }
}
