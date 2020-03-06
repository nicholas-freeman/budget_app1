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
        public FormBudgetApp()
        {
            InitializeComponent();
            comboBoxBudgets.Items.Add("placeholder 1");
            comboBoxBudgets.Items.Add("placeholder 2");
        }
    }
}
