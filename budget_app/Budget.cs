using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget_app
{
    public class Budget
    {
        public List<Item> budget_items;
        string budget_name;
        public string Budget_name
        {
            get { return budget_name; }
            set { budget_name = value; }
        }

        public Budget(string n) //constructor
        {
            this.budget_items = new List<Item>();
            this.budget_name = n;
        }

        public void addItem( Item item )
        {
            budget_items.Add(item);
        }
        public void removeItem( int loc ) //implement removing multiple items at once later
        {
            budget_items.RemoveAt(loc);
        }
    }
}
