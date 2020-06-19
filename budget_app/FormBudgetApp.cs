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
        //List<Budget> budgets;
        //path to xml file "../../Saved_Budgets.xml"
        public FormBudgetApp()
        {
            InitializeComponent();
            //add loaded(existing) budgets to the comboBox
            for (int i = 0; i < Globals.Budgets.Count; i++)
            {
                comboBoxBudgets.Items.Add(Globals.Budgets[i].Budget_name);
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
    }
}
