namespace ExpenseTracker
{
    partial class Users
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.UPhoneTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UPasswordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddBtn.Location = new System.Drawing.Point(432, 593);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 25);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add User";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address";
            // 
            // UDOB
            // 
            this.UDOB.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDOB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UDOB.Location = new System.Drawing.Point(279, 58);
            this.UDOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UDOB.Name = "UDOB";
            this.UDOB.Size = new System.Drawing.Size(180, 20);
            this.UDOB.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date of Birth";
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(279, 133);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(217, 54);
            this.AddressTb.TabIndex = 16;
            // 
            // UPhoneTb
            // 
            this.UPhoneTb.Location = new System.Drawing.Point(500, 60);
            this.UPhoneTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UPhoneTb.Name = "UPhoneTb";
            this.UPhoneTb.Size = new System.Drawing.Size(180, 22);
            this.UPhoneTb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone Number";
            // 
            // UnameTb
            // 
            this.UnameTb.Location = new System.Drawing.Point(49, 58);
            this.UnameTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(180, 22);
            this.UnameTb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // UPasswordTb
            // 
            this.UPasswordTb.Location = new System.Drawing.Point(49, 133);
            this.UPasswordTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UPasswordTb.Name = "UPasswordTb";
            this.UPasswordTb.Size = new System.Drawing.Size(180, 22);
            this.UPasswordTb.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // UsersDGV
            // 
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Location = new System.Drawing.Point(49, 212);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.Size = new System.Drawing.Size(824, 375);
            this.UsersDGV.TabIndex = 24;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 624);
            this.Controls.Add(this.UsersDGV);
            this.Controls.Add(this.UPasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.UPhoneTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker UDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox UPhoneTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UPasswordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UsersDGV;
    }
}