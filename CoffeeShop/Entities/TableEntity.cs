using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class TableEntity
    {
        public int table_id;
        public string name;
        public string description;
        public bool is_busy;

        public TableEntity setId(int id)
        {
            this.table_id = id;
            return this;
        }
        public TableEntity setName(string name)
        {
            this.name = name;
            return this;
        }
        public TableEntity setDescription(string desc)
        {
            this.description = desc;
            return this;
        }
        public TableEntity setIsBusy(bool is_busy)
        {
            this.is_busy = is_busy;
            return this;
        }
    }
}
