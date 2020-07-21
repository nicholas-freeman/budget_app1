using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace budget_app
{
    static class Globals
    {
        public static List<Budget> Budgets;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            void loadXmlBudgets()
            {
                FileStream fs = new FileStream("../../Saved_Budgets.xml", FileMode.Open, FileAccess.Read);
                XmlTextReader xmlReader = new XmlTextReader(fs);
                Budget tmp_budget = new Budget("");
                string new_item_name = null;
                string new_item_desc = null;
                int new_item_val = 0;
                int new_spent_val = 0;
                while (xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            //start of new budget - set a new tmp_budget
                            if (xmlReader.Name == "Budget_name")
                            {
                                tmp_budget = new Budget(xmlReader.ReadInnerXml().Trim());
                                //Console.WriteLine(tmp_budget.Budget_name);
                            }
                            //start of new item
                            else if (xmlReader.Name == "Item_name")
                            {
                                new_item_name = xmlReader.ReadInnerXml().Trim();
                            }
                            if (xmlReader.Name == "Item_val")
                            {
                                new_item_val = Int32.Parse(xmlReader.ReadInnerXml().Trim());
                            }
                            else if (xmlReader.Name == "Spent_val")
                            {
                                new_spent_val = Int32.Parse(xmlReader.ReadInnerXml().Trim());
                            }
                            if (xmlReader.Name == "Item_desc")
                            {
                                new_item_desc = xmlReader.ReadInnerXml().Trim();
                            }
                            break;
                        case XmlNodeType.EndElement:
                            //end of an item -> add item to current tmp_budget
                            if (xmlReader.Name == "Item")
                            {
                                tmp_budget.addItem(new Item(new_item_name, new_item_val, new_spent_val, new_item_desc));
                            }
                            //end of budget -> add tmp_budget to list
                            else if (xmlReader.Name == "Budget")
                            {
                                Globals.Budgets.Add(tmp_budget);
                                //tmp_budget = new Budget("");
                            }
                            break;
                    }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //load in budgets to Global list from XML
            Globals.Budgets = new List<Budget>();

            loadXmlBudgets();

            Application.Run(new FormBudgetApp());
        }
    }
}
