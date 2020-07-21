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
            this.buttonNewBudget = new System.Windows.Forms.Button();
            this.buttonEditBudget = new System.Windows.Forms.Button();
            this.labelItemValueBudgeted = new System.Windows.Forms.Label();
            this.labelItemValueSpent = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxAddSpentValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddSpentValue = new System.Windows.Forms.Button();
            this.labelBudgetOverUnder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBudgets
            // 
            this.comboBoxBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudgets.FormattingEnabled = true;
            this.comboBoxBudgets.Location = new System.Drawing.Point(12, 27);
            this.comboBoxBudgets.Name = "comboBoxBudgets";
            this.comboBoxBudgets.Size = new System.Drawing.Size(125, 21);
            this.comboBoxBudgets.TabIndex = 1;
            this.comboBoxBudgets.SelectedIndexChanged += new System.EventHandler(this.comboBoxBudgets_SelectedIndexChanged);
            // 
            // comboBoxBudgetItems
            // 
            this.comboBoxBudgetItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudgetItems.FormattingEnabled = true;
            this.comboBoxBudgetItems.Location = new System.Drawing.Point(157, 27);
            this.comboBoxBudgetItems.Name = "comboBoxBudgetItems";
            this.comboBoxBudgetItems.Size = new System.Drawing.Size(141, 21);
            this.comboBoxBudgetItems.TabIndex = 2;
            this.comboBoxBudgetItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxBudgetItems_SelectedIndexChanged);
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
            // buttonNewBudget
            // 
            this.buttonNewBudget.Location = new System.Drawing.Point(12, 370);
            this.buttonNewBudget.Name = "buttonNewBudget";
            this.buttonNewBudget.Size = new System.Drawing.Size(115, 23);
            this.buttonNewBudget.TabIndex = 5;
            this.buttonNewBudget.Text = "Create New Budget";
            this.buttonNewBudget.UseVisualStyleBackColor = true;
            this.buttonNewBudget.Click += new System.EventHandler(this.buttonNewBudget_Click);
            // 
            // buttonEditBudget
            // 
            this.buttonEditBudget.Location = new System.Drawing.Point(157, 370);
            this.buttonEditBudget.Name = "buttonEditBudget";
            this.buttonEditBudget.Size = new System.Drawing.Size(118, 23);
            this.buttonEditBudget.TabIndex = 6;
            this.buttonEditBudget.Text = "Edit Selected Budget";
            this.buttonEditBudget.UseVisualStyleBackColor = true;
            this.buttonEditBudget.Click += new System.EventHandler(this.buttonEditBudget_Click);
            // 
            // labelItemValueBudgeted
            // 
            this.labelItemValueBudgeted.AutoSize = true;
            this.labelItemValueBudgeted.Location = new System.Drawing.Point(154, 64);
            this.labelItemValueBudgeted.Name = "labelItemValueBudgeted";
            this.labelItemValueBudgeted.Size = new System.Drawing.Size(122, 13);
            this.labelItemValueBudgeted.TabIndex = 7;
            this.labelItemValueBudgeted.Text = "labelItemValueBudgeted";
            // 
            // labelItemValueSpent
            // 
            this.labelItemValueSpent.AutoSize = true;
            this.labelItemValueSpent.Location = new System.Drawing.Point(154, 87);
            this.labelItemValueSpent.Name = "labelItemValueSpent";
            this.labelItemValueSpent.Size = new System.Drawing.Size(104, 13);
            this.labelItemValueSpent.TabIndex = 8;
            this.labelItemValueSpent.Text = "labelItemValueSpent";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(154, 164);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(265, 161);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "labelDesciption";
            // 
            // textBoxAddSpentValue
            // 
            this.textBoxAddSpentValue.Location = new System.Drawing.Point(157, 143);
            this.textBoxAddSpentValue.Name = "textBoxAddSpentValue";
            this.textBoxAddSpentValue.Size = new System.Drawing.Size(101, 20);
            this.textBoxAddSpentValue.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(154, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Set the spent value with the following field";
            // 
            // buttonAddSpentValue
            // 
            this.buttonAddSpentValue.Location = new System.Drawing.Point(264, 143);
            this.buttonAddSpentValue.Name = "buttonAddSpentValue";
            this.buttonAddSpentValue.Size = new System.Drawing.Size(45, 20);
            this.buttonAddSpentValue.TabIndex = 12;
            this.buttonAddSpentValue.Text = "Set";
            this.buttonAddSpentValue.UseVisualStyleBackColor = true;
            this.buttonAddSpentValue.Click += new System.EventHandler(this.buttonAddSpentValue_Click);
            // 
            // labelBudgetOverUnder
            // 
            this.labelBudgetOverUnder.AutoSize = true;
            this.labelBudgetOverUnder.Location = new System.Drawing.Point(154, 109);
            this.labelBudgetOverUnder.Name = "labelBudgetOverUnder";
            this.labelBudgetOverUnder.Size = new System.Drawing.Size(115, 13);
            this.labelBudgetOverUnder.TabIndex = 13;
            this.labelBudgetOverUnder.Text = "labelBudgetOverUnder";
            // 
            // FormBudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 417);
            this.Controls.Add(this.labelBudgetOverUnder);
            this.Controls.Add(this.textBoxAddSpentValue);
            this.Controls.Add(this.buttonAddSpentValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelItemValueSpent);
            this.Controls.Add(this.labelItemValueBudgeted);
            this.Controls.Add(this.buttonEditBudget);
            this.Controls.Add(this.buttonNewBudget);
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
        private System.Windows.Forms.Button buttonNewBudget;
        private System.Windows.Forms.Button buttonEditBudget;
        private System.Windows.Forms.Label labelItemValueBudgeted;
        private System.Windows.Forms.Label labelItemValueSpent;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxAddSpentValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSpentValue;
        private System.Windows.Forms.Label labelBudgetOverUnder;
    }
}

