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
        private readonly string VAL_PROMPT = "Item_Value";
        private readonly string SPENT_PROMPT = "Spent_value";
        
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
            textBoxSpent.Show();
            comboBoxItems.Show();
            //reset text boxes for adding/editing items - rename form to budget's name
            this.Text = bgt.Budget_name;
            textBoxName.Text = NAME_PROMPT;
            textBoxDescription.Text = DESC_PROMPT;
            textBoxValue.Text = VAL_PROMPT;
            textBoxSpent.Text = SPENT_PROMPT;
            comboBoxItems.SelectedIndex = 0;
            textBoxName.SelectAll();
        }
        public FormEditBudget() //new budget
        {
            InitializeComponent();
            comboBoxItems.DropDownStyle = ComboBoxStyle.DropDownList;
            //hide what we don't need right away
            comboBoxItems.Hide();
            buttonEnterItem.Hide();
            buttonSaveExit.Hide();
            textBoxValue.Hide();
            textBoxSpent.Hide();
            this.Text = "New Budget";
            comboBoxItems.Items.Add("*New Item*");
            //do something with this later
            comboBoxDuration.Hide();
            comboBoxDuration.Items.Add("Weekly");
            comboBoxDuration.Items.Add("Monthly");
            comboBoxDuration.Items.Add("Yearly");
        }
        public FormEditBudget(int b_index) //load existing budget to edit
        {
            InitializeComponent();
            comboBoxItems.DropDownStyle = ComboBoxStyle.DropDownList;
            //create local instance of budget
            bgt = Globals.Budgets[b_index];
            //load the items into the item list
            comboBoxItems.Items.Add("*New Item*"); //start with selector for new budget item
            for (int i=0; i<bgt.budget_items.Count; i++)
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
            //dont edit spent value in this window
            Item itm = new Item(textBoxName.Text, Int32.Parse(textBoxValue.Text), Int32.Parse(textBoxSpent.Text), textBoxDescription.Text);
            //editing an existing item
            if (comboBoxItems.SelectedIndex == 0) //new item selected
            {
                bgt.addItem(itm);
                comboBoxItems.Items.Add(itm.Item_name);
                textBoxName.Text = NAME_PROMPT;
                textBoxDescription.Text = DESC_PROMPT;
                textBoxValue.Text = VAL_PROMPT;
                textBoxSpent.Text = SPENT_PROMPT;
            }
            //creating a new item
            else //existing item selected
            {
                bgt.budget_items[comboBoxItems.SelectedIndex - 1] = itm;
            }
            comboBoxItems.SelectedIndex = 0; //runs comboBoxSelectedIndexChanged if edited item
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxItems.SelectedIndex == 0) //new item selected
            {
                //do stuff
                textBoxName.Text = NAME_PROMPT;
                textBoxDescription.Text = DESC_PROMPT;
                textBoxValue.Text = VAL_PROMPT;
                textBoxSpent.Text = SPENT_PROMPT;
            }
            else //existing item selected
            {
                textBoxName.Text = bgt.budget_items[comboBoxItems.SelectedIndex - 1].Item_name;
                textBoxDescription.Text = bgt.budget_items[comboBoxItems.SelectedIndex - 1].Item_desc;
                textBoxValue.Text = bgt.budget_items[comboBoxItems.SelectedIndex - 1].Item_value.ToString();
                textBoxSpent.Text = bgt.budget_items[comboBoxItems.SelectedIndex - 1].Spent_value.ToString();
            }
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            //quitting
            Globals.Budgets.Add(bgt);
            this.Close();
        }
    }
}
