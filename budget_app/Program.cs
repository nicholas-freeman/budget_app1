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
                Item tmp_item;
                bool new_budget_flag = false;
                int new_item_flag = 0;
                string new_item_name = null;
                int new_item_val = 0;
                while (xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (xmlReader.Name == "Budget_name")
                            {
                                new_budget_flag = true;
                            }
                            else if (xmlReader.Name == "Item_name")
                            {
                                new_item_flag = 2;
                            }
                            else if (xmlReader.Name == "Item_val")
                            {
                                new_item_flag = 1;
                            }
                            //Console.WriteLine("element");
                            break;
                        case XmlNodeType.Text:
                            if (new_budget_flag == true)
                            {
                                tmp_budget.Budget_name = xmlReader.Value.Trim();
                                new_budget_flag = false;
                            }
                            else if (new_item_flag == 2)
                            {
                                new_item_name = xmlReader.Value.Trim();
                                new_item_flag = 0;
                            }
                            else if (new_item_flag == 1)
                            {
                                new_item_val = Int32.Parse(xmlReader.Value.Trim());
                                tmp_item = new Item(new_item_name, new_item_val);
                                tmp_budget.addItem(tmp_item);
                                new_item_flag = 0;
                            }
                            //Console.WriteLine(xmlReader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            if (xmlReader.Name == "Budget")
                            {
                                Globals.Budgets.Add(tmp_budget);
                                tmp_budget = new Budget("");
                            }
                            //Console.WriteLine("end element");
                            //add new budget down here
                            break;
                    }
                }

                Console.WriteLine(Globals.Budgets[0].budget_items[0].Item_name);
                Console.WriteLine(Globals.Budgets[1].budget_items[0].Item_name);
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
