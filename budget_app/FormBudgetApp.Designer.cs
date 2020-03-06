namespace budget_app
{
    partial class FormBudgetApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxBudgets = new System.Windows.Forms.ComboBox();
            this.comboBoxBudgetItems = new System.Windows.Forms.ComboBox();
            this.labelBudgetSelector = new System.Windows.Forms.Label();
            this.labelBudgetItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBudgets
            // 
            this.comboBoxBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudgets.FormattingEnabled = true;
            this.comboBoxBudgets.Location = new System.Drawing.Point(12, 27);
            this.comboBoxBudgets.Name = "comboBoxBudgets";
            this.comboBoxBudgets.Size = new System.Drawing.Size(107, 21);
            this.comboBoxBudgets.TabIndex = 1;
            // 
            // comboBoxBudgetItems
            // 
            this.comboBoxBudgetItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudgetItems.FormattingEnabled = true;
            this.comboBoxBudgetItems.Location = new System.Drawing.Point(157, 27);
            this.comboBoxBudgetItems.Name = "comboBoxBudgetItems";
            this.comboBoxBudgetItems.Size = new System.Drawing.Size(141, 21);
            this.comboBoxBudgetItems.TabIndex = 2;
            // 
            // labelBudgetSelector
            // 
            this.labelBudgetSelector.AutoSize = true;
            this.labelBudgetSelector.Location = new System.Drawing.Point(12, 9);
            this.labelBudgetSelector.Name = "labelBudgetSelector";
            this.labelBudgetSelector.Size = new System.Drawing.Size(41, 13);
            this.labelBudgetSelector.TabIndex = 3;
            this.labelBudgetSelector.Text = "Budget";
            // 
            // labelBudgetItems
            // 
            this.labelBudgetItems.AutoSize = true;
            this.labelBudgetItems.Location = new System.Drawing.Point(154, 9);
            this.labelBudgetItems.Name = "labelBudgetItems";
            this.labelBudgetItems.Size = new System.Drawing.Size(121, 13);
            this.labelBudgetItems.TabIndex = 4;
            this.labelBudgetItems.Text = "Selected Budget\'s Items";
            // 
            // FormBudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 417);
            this.Controls.Add(this.labelBudgetItems);
            this.Controls.Add(this.labelBudgetSelector);
            this.Controls.Add(this.comboBoxBudgetItems);
            this.Controls.Add(this.comboBoxBudgets);
            this.Name = "FormBudgetApp";
            this.Text = "Budgeting App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBudgets;
        private System.Windows.Forms.ComboBox comboBoxBudgetItems;
        private System.Windows.Forms.Label labelBudgetSelector;
        private System.Windows.Forms.Label labelBudgetItems;
    }
}

