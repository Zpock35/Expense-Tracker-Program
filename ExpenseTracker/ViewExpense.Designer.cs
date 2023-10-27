namespace ExpenseTracker
{
    partial class ViewExpense
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
            this.ExpenseDGV = new System.Windows.Forms.DataGridView();
            this.ExpCatCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseDGV
            // 
            this.ExpenseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseDGV.Location = new System.Drawing.Point(50, 84);
            this.ExpenseDGV.Name = "ExpenseDGV";
            this.ExpenseDGV.Size = new System.Drawing.Size(824, 375);
            this.ExpenseDGV.TabIndex = 25;
            // 
            // ExpCatCb
            // 
            this.ExpCatCb.FormattingEnabled = true;
            this.ExpCatCb.Items.AddRange(new object[] {
            "Bills",
            "Food",
            "Entertainment",
            "Medical",
            "Travel",
            "Others"});
            this.ExpCatCb.Location = new System.Drawing.Point(203, 40);
            this.ExpCatCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpCatCb.Name = "ExpCatCb";
            this.ExpCatCb.Size = new System.Drawing.Size(180, 22);
            this.ExpCatCb.TabIndex = 27;
            this.ExpCatCb.SelectionChangeCommitted += new System.EventHandler(this.ExpCatCb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Category";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(391, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExpCatCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpenseDGV);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewExpense";
            this.Text = "ViewExpense";
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ExpenseDGV;
        private System.Windows.Forms.ComboBox ExpCatCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}