namespace ExpenseTracker
{
    partial class AddExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExpNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpAmtTb = new System.Windows.Forms.TextBox();
            this.ExpDescTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpCatCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ExpNameTb
            // 
            this.ExpNameTb.Location = new System.Drawing.Point(107, 54);
            this.ExpNameTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpNameTb.Name = "ExpNameTb";
            this.ExpNameTb.Size = new System.Drawing.Size(180, 22);
            this.ExpNameTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // ExpAmtTb
            // 
            this.ExpAmtTb.Location = new System.Drawing.Point(107, 121);
            this.ExpAmtTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpAmtTb.Name = "ExpAmtTb";
            this.ExpAmtTb.Size = new System.Drawing.Size(180, 22);
            this.ExpAmtTb.TabIndex = 3;
            // 
            // ExpDescTb
            // 
            this.ExpDescTb.Location = new System.Drawing.Point(107, 325);
            this.ExpDescTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpDescTb.Multiline = true;
            this.ExpDescTb.Name = "ExpDescTb";
            this.ExpDescTb.Size = new System.Drawing.Size(180, 86);
            this.ExpDescTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
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
            this.ExpCatCb.Location = new System.Drawing.Point(107, 187);
            this.ExpCatCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpCatCb.Name = "ExpCatCb";
            this.ExpCatCb.Size = new System.Drawing.Size(180, 22);
            this.ExpCatCb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ExpDate
            // 
            this.ExpDate.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpDate.Location = new System.Drawing.Point(107, 256);
            this.ExpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(180, 20);
            this.ExpDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.AddBtn.Location = new System.Drawing.Point(141, 446);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 25);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add Expense";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(392, 551);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExpCatCb);
            this.Controls.Add(this.ExpDescTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpAmtTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpNameTb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExpNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpAmtTb;
        private System.Windows.Forms.TextBox ExpDescTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ExpCatCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
    }
}