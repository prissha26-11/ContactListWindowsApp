namespace SQLite_Database_Project
{
    partial class Form1
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
            this.ContactsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Email_Text = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Phone_Text = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DeleteAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactsDataGridView1
            // 
            this.ContactsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsDataGridView1.Location = new System.Drawing.Point(328, 131);
            this.ContactsDataGridView1.Name = "ContactsDataGridView1";
            this.ContactsDataGridView1.RowHeadersWidth = 51;
            this.ContactsDataGridView1.RowTemplate.Height = 24;
            this.ContactsDataGridView1.Size = new System.Drawing.Size(499, 240);
            this.ContactsDataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQLite Database";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(29, 122);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(68, 25);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Name";
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(34, 150);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(252, 22);
            this.Name_Text.TabIndex = 3;
            // 
            // Email_Text
            // 
            this.Email_Text.Location = new System.Drawing.Point(34, 225);
            this.Email_Text.Name = "Email_Text";
            this.Email_Text.Size = new System.Drawing.Size(252, 22);
            this.Email_Text.TabIndex = 5;
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Label.Location = new System.Drawing.Point(29, 197);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(65, 25);
            this.Email_Label.TabIndex = 4;
            this.Email_Label.Text = "Email";
            // 
            // Phone_Text
            // 
            this.Phone_Text.Location = new System.Drawing.Point(34, 297);
            this.Phone_Text.Name = "Phone_Text";
            this.Phone_Text.Size = new System.Drawing.Size(252, 22);
            this.Phone_Text.TabIndex = 7;
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Label.Location = new System.Drawing.Point(29, 269);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(74, 25);
            this.Phone_Label.TabIndex = 6;
            this.Phone_Label.Text = "Phone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.LightGreen;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(174, 350);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(132, 40);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Pink;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(36, 396);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 40);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeleteAllBtn
            // 
            this.DeleteAllBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllBtn.Location = new System.Drawing.Point(174, 396);
            this.DeleteAllBtn.Name = "DeleteAllBtn";
            this.DeleteAllBtn.Size = new System.Drawing.Size(132, 40);
            this.DeleteAllBtn.TabIndex = 11;
            this.DeleteAllBtn.Text = "Delete All";
            this.DeleteAllBtn.UseVisualStyleBackColor = false;
            this.DeleteAllBtn.Click += new System.EventHandler(this.DeleteAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 478);
            this.Controls.Add(this.DeleteAllBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Phone_Text);
            this.Controls.Add(this.Phone_Label);
            this.Controls.Add(this.Email_Text);
            this.Controls.Add(this.Email_Label);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactsDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ContactsDataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Email_Text;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.TextBox Phone_Text;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button DeleteAllBtn;
    }
}

