using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budget_app
{
    public partial class FormBudgetApp : Form
    {
        private string VALUESTR_BGTD = "Budgeted value: ";
        private string VALUESTR_SPNT = "Spent value: ";
        private string ITEM_DESC = "Description: ";
        //path to xml file "../../Saved_Budgets.xml"
        Budget bgt;
        Item itm;
        public FormBudgetApp()
        {
            InitializeComponent();
            //hide labels not in use
            labelItemValueBudgeted.Text = VALUESTR_BGTD;
            labelItemValueSpent.Text = VALUESTR_SPNT;
            labelDescription.Text = ITEM_DESC;
            //add loaded(existing) budgets to the comboBox
            for (int i = 0; i < Globals.Budgets.Count; i++)
            {
                comboBoxBudgets.Items.Add(Globals.Budgets[i].Budget_name);
            }
        }
        private string overUnderBudgetLabeling()
        {
            int v = itm.Item_value - itm.Spent_value;
            if(v < 0)
            {
                return "This item is currently $" + (v * -1).ToString() + " over budget.";
            }
            else
            {
                return "This item is currently $" + v.ToString() + " under budget";
            }
        }
        private void buttonNewBudget_Click(object sender, EventArgs e)
        {
            FormEditBudget edit = new FormEditBudget();
            this.Hide();
            edit.ShowDialog();
            this.Show();
            //add the created budget to the dropbox
            comboBoxBudgets.Items.Add(Globals.Budgets[Globals.Budgets.Count-1].Budget_name);

        }
        private void buttonEditBudget_Click(object sender, EventArgs e)
        {
            FormEditBudget edit = new FormEditBudget(comboBoxBudgets.SelectedIndex);
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }

        private void comboBoxBudgetItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change item information labels
            itm = bgt.budget_items[comboBoxBudgetItems.SelectedIndex];
            //empty text box and set labels
            textBoxAddSpentValue.Text = "";
            labelItemValueBudgeted.Text = VALUESTR_BGTD + "$" + itm.Item_value.ToString();
            labelItemValueSpent.Text = VALUESTR_SPNT + "$" + itm.Spent_value.ToString();
            labelBudgetOverUnder.Text = overUnderBudgetLabeling();
            labelDescription.Text = ITEM_DESC + itm.Item_desc;
        }

        private void comboBoxBudgets_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBudgetItems.Items.Clear();
            int ix = comboBoxBudgets.SelectedIndex;
            bgt = Globals.Budgets[ix];
            for(int i=0; i<bgt.budget_items.Count; i++)
            {
                comboBoxBudgetItems.Items.Add(bgt.budget_items[i].Item_name);
            }
            textBoxAddSpentValue.Text = "";
            labelItemValueBudgeted.Text = VALUESTR_BGTD;
            labelItemValueSpent.Text = VALUESTR_SPNT;
            labelDescription.Text = ITEM_DESC;
        }

        private void buttonAddSpentValue_Click(object sender, EventArgs e)
        {
            //set items spent value to new input
            itm.Spent_value = Int32.Parse(textBoxAddSpentValue.Text);
            //change labels and clear text box
            labelItemValueSpent.Text = VALUESTR_SPNT + "$" + itm.Spent_value.ToString();
            labelBudgetOverUnder.Text = overUnderBudgetLabeling();
            textBoxAddSpentValue.Text = "";
        }
    }
}
