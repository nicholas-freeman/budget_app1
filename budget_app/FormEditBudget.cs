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
    public partial class FormEditBudget : Form
    {
        //constants for field resets
        private readonly string NAME_PROMPT = "Item_Name";
        private readonly string DESC_PROMPT = "Item_Description";
        private readonly string VAL_PROMPT = "Numeric_Value";
        
        private Budget bgt;
        private void end_creation()
        {
            //hide what we no longer need
            buttonCreate.Hide();
            comboBoxDuration.Hide();
            labelNewBudgetPrompt.Hide();
            //show what we need
            buttonEnterItem.Show();
            buttonSaveExit.Show();
            textBoxValue.Show();
            comboBoxItems.Show();
            //reset text boxes for adding/editing items - rename form to budget's name
            this.Text = bgt.Budget_name;
            textBoxName.Text = NAME_PROMPT;
            textBoxDescription.Text = DESC_PROMPT;
            textBoxValue.Text = VAL_PROMPT;
        }
        public FormEditBudget() //new budget
        {
            InitializeComponent();
            //hide what we don't need right away
            comboBoxItems.Hide();
            buttonEnterItem.Hide();
            buttonSaveExit.Hide();
            textBoxValue.Hide();
            this.Text = "New Budget";
            comboBoxDuration.Items.Add("Weekly");
            comboBoxDuration.Items.Add("Monthly");
            comboBoxDuration.Items.Add("Yearly");
        }
        public FormEditBudget(int b_index) //load existing budget to edit
        {
            InitializeComponent();
            //create local instance of budget
            bgt = Globals.Budgets[b_index];
            //load the items into the item list
            for(int i=0; i<bgt.budget_items.Count; i++)
            {
                comboBoxItems.Items.Add(bgt.budget_items[i].Item_name);
            }
            end_creation();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test button output:");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            bgt = new Budget(textBoxName.Text);
            //hide creation prompts and buttons
            end_creation();            
        }
        private void buttonEnterItem_Click(object sender, EventArgs e)
        {
            Item itm = new Item(textBoxName.Text, Int32.Parse(textBoxValue.Text));
            //editing an existing item
            if (comboBoxItems.SelectedItem != null)
            {
                MessageBox.Show("gotta do some different stuff");
                bgt.budget_items[comboBoxItems.SelectedIndex] = itm;
            }
            //creating a new item
            else
            {
                bgt.addItem(itm);
                comboBoxItems.Items.Add(itm.Item_name);
            }
            textBoxName.Text = NAME_PROMPT;
            textBoxDescription.Text = DESC_PROMPT;
            textBoxValue.Text = VAL_PROMPT;
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxItems.SelectedItem.ToString());
            textBoxName.Text = bgt.budget_items[comboBoxItems.SelectedIndex].Item_name;
            textBoxValue.Text = bgt.budget_items[comboBoxItems.SelectedIndex].Item_value.ToString();
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            //quitting
            Globals.Budgets.Add(bgt);
            this.Close();
        }
    }
}
