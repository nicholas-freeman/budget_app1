namespace budget_app
{
    partial class FormEditBudget
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
            this.buttonEnterItem = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelNewBudgetPrompt = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonSaveExit = new System.Windows.Forms.Button();
            this.textBoxSpent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnterItem
            // 
            this.buttonEnterItem.Location = new System.Drawing.Point(26, 156);
            this.buttonEnterItem.Name = "buttonEnterItem";
            this.buttonEnterItem.Size = new System.Drawing.Size(75, 23);
            this.buttonEnterItem.TabIndex = 0;
            this.buttonEnterItem.Text = "Enter Item";
            this.buttonEnterItem.UseVisualStyleBackColor = true;
            this.buttonEnterItem.Click += new System.EventHandler(this.buttonEnterItem_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(26, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Name";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(26, 12);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(198, 21);
            this.comboBoxItems.TabIndex = 2;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(465, 116);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "test button";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelNewBudgetPrompt
            // 
            this.labelNewBudgetPrompt.AutoSize = true;
            this.labelNewBudgetPrompt.Location = new System.Drawing.Point(23, 36);
            this.labelNewBudgetPrompt.Name = "labelNewBudgetPrompt";
            this.labelNewBudgetPrompt.Size = new System.Drawing.Size(245, 13);
            this.labelNewBudgetPrompt.TabIndex = 4;
            this.labelNewBudgetPrompt.Text = "Enter the following information for your new budget";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(26, 78);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(198, 20);
            this.textBoxDescription.TabIndex = 5;
            this.textBoxDescription.Text = "Description";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Location = new System.Drawing.Point(283, 52);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(101, 21);
            this.comboBoxDuration.TabIndex = 6;
            this.comboBoxDuration.Text = "Duration";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(400, 52);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(88, 21);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Create Budget";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(26, 104);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(103, 20);
            this.textBoxValue.TabIndex = 8;
            this.textBoxValue.Text = "Item_Value";
            // 
            // buttonSaveExit
            // 
            this.buttonSaveExit.Location = new System.Drawing.Point(536, 368);
            this.buttonSaveExit.Name = "buttonSaveExit";
            this.buttonSaveExit.Size = new System.Drawing.Size(87, 41);
            this.buttonSaveExit.TabIndex = 9;
            this.buttonSaveExit.Text = "Save and Exit";
            this.buttonSaveExit.UseVisualStyleBackColor = true;
            this.buttonSaveExit.Click += new System.EventHandler(this.buttonSaveExit_Click);
            // 
            // textBoxSpent
            // 
            this.textBoxSpent.Location = new System.Drawing.Point(26, 130);
            this.textBoxSpent.Name = "textBoxSpent";
            this.textBoxSpent.Size = new System.Drawing.Size(103, 20);
            this.textBoxSpent.TabIndex = 10;
            this.textBoxSpent.Text = "Spent_value";
            // 
            // FormEditBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 421);
            this.Controls.Add(this.textBoxSpent);
            this.Controls.Add(this.buttonSaveExit);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelNewBudgetPrompt);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEnterItem);
            this.Name = "FormEditBudget";
            this.Text = "FormEditBudget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterItem;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelNewBudgetPrompt;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonSaveExit;
        private System.Windows.Forms.TextBox textBoxSpent;
    }
}