using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget_app
{
    // class that defines income/spending in the budget
    public class Item
    {
        private string item_name;
        public string Item_name
        {
            get { return item_name; }
            set { item_name = value; }
        }
        private int item_value;
        public int Item_value
        {
            get { return item_value; }
            set { item_value = value; }
        }
        public Item(string n, int val) //constructor
        {
            this.item_name = n;
            this.item_value = val;
        }
        /*
        private int spent_value;

        public int Spent_value
        {
            get { return spent_value; }
            set { spent_value = 0;
        }     
         */
    }
}
