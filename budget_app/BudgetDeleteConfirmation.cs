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
    public partial class BudgetDeleteConfirmation : Form
    {
        private bool del_bud;
        public bool Del_bud 
        {
            get { return del_bud; }
        }

        public BudgetDeleteConfirmation(string bname)
        {
            InitializeComponent();
            labelMessage.Text = "Are you sure you want to delete \"" + bname + "\"?";
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            del_bud = true;
            this.Hide();
        }
        private void buttonNo_Click(object sender, EventArgs e)
        {
            del_bud = false;
            this.Hide();
        }

    }
}
