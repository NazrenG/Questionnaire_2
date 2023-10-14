namespace Questionnarie2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.textBox2_surname = new System.Windows.Forms.TextBox();
            this.textBox3_mail = new System.Windows.Forms.TextBox();
            this.textBox4_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.button1_add = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.button1_writeNewFile = new System.Windows.Forms.Button();
            this.button2_searchFile = new System.Windows.Forms.Button();
            this.button_changeData = new System.Windows.Forms.Button();
            this.button1_save_change = new System.Windows.Forms.Button();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Anket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tel";
            // 
            // textBox1_name
            // 
            this.textBox1_name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1_name.Location = new System.Drawing.Point(60, 88);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(200, 22);
            this.textBox1_name.TabIndex = 1;
            this.textBox1_name.TextChanged += new System.EventHandler(this.textBox1_name_TextChanged);
            // 
            // textBox2_surname
            // 
            this.textBox2_surname.Location = new System.Drawing.Point(60, 124);
            this.textBox2_surname.Name = "textBox2_surname";
            this.textBox2_surname.Size = new System.Drawing.Size(200, 23);
            this.textBox2_surname.TabIndex = 1;
            this.textBox2_surname.TextChanged += new System.EventHandler(this.textBox2_surname_TextChanged);
            // 
            // textBox3_mail
            // 
            this.textBox3_mail.Location = new System.Drawing.Point(60, 162);
            this.textBox3_mail.Name = "textBox3_mail";
            this.textBox3_mail.Size = new System.Drawing.Size(200, 23);
            this.textBox3_mail.TabIndex = 1;
            this.textBox3_mail.TextChanged += new System.EventHandler(this.textBox3_mail_TextChanged);
            // 
            // textBox4_tel
            // 
            this.textBox4_tel.Location = new System.Drawing.Point(60, 201);
            this.textBox4_tel.Name = "textBox4_tel";
            this.textBox4_tel.Size = new System.Drawing.Size(200, 23);
            this.textBox4_tel.TabIndex = 1;
            this.textBox4_tel.TextChanged += new System.EventHandler(this.textBox4_tel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doğum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(314, 36);
            this.ListBox.Name = "ListBox";
            this.ListBox.ScrollAlwaysVisible = true;
            this.ListBox.Size = new System.Drawing.Size(187, 214);
            this.ListBox.TabIndex = 3;
            // 
            // button1_add
            // 
            this.button1_add.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.button1_add.FlatAppearance.BorderSize = 0;
            this.button1_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_add.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1_add.Location = new System.Drawing.Point(60, 292);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(75, 26);
            this.button1_add.TabIndex = 4;
            this.button1_add.Text = "Əlavə et";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_message.ForeColor = System.Drawing.Color.Green;
            this.label_message.Location = new System.Drawing.Point(2, 331);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 17);
            this.label_message.TabIndex = 0;
            this.label_message.Visible = false;
            // 
            // button1_writeNewFile
            // 
            this.button1_writeNewFile.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.button1_writeNewFile.FlatAppearance.BorderSize = 0;
            this.button1_writeNewFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1_writeNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1_writeNewFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_writeNewFile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1_writeNewFile.Location = new System.Drawing.Point(408, 289);
            this.button1_writeNewFile.Name = "button1_writeNewFile";
            this.button1_writeNewFile.Size = new System.Drawing.Size(93, 26);
            this.button1_writeNewFile.TabIndex = 4;
            this.button1_writeNewFile.Text = "Fayl-a yaz";
            this.button1_writeNewFile.UseVisualStyleBackColor = true;
            this.button1_writeNewFile.Click += new System.EventHandler(this.button1_writeNewFile_Click);
            // 
            // button2_searchFile
            // 
            this.button2_searchFile.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.button2_searchFile.FlatAppearance.BorderSize = 0;
            this.button2_searchFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button2_searchFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button2_searchFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_searchFile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2_searchFile.Location = new System.Drawing.Point(314, 289);
            this.button2_searchFile.Name = "button2_searchFile";
            this.button2_searchFile.Size = new System.Drawing.Size(83, 26);
            this.button2_searchFile.TabIndex = 4;
            this.button2_searchFile.Text = "Axtarış et";
            this.button2_searchFile.UseVisualStyleBackColor = true;
            this.button2_searchFile.Click += new System.EventHandler(this.button2_searchFile_Click);
            // 
            // button_changeData
            // 
            this.button_changeData.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.button_changeData.FlatAppearance.BorderSize = 0;
            this.button_changeData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button_changeData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.button_changeData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_changeData.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button_changeData.Location = new System.Drawing.Point(185, 292);
            this.button_changeData.Name = "button_changeData";
            this.button_changeData.Size = new System.Drawing.Size(75, 26);
            this.button_changeData.TabIndex = 4;
            this.button_changeData.Text = "Dəyiş";
            this.button_changeData.UseVisualStyleBackColor = true;
            this.button_changeData.Click += new System.EventHandler(this.button_changeData_Click);
            // 
            // button1_save_change
            // 
            this.button1_save_change.AutoSize = true;
            this.button1_save_change.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_save_change.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1_save_change.Location = new System.Drawing.Point(3, 292);
            this.button1_save_change.Name = "button1_save_change";
            this.button1_save_change.Size = new System.Drawing.Size(150, 29);
            this.button1_save_change.TabIndex = 5;
            this.button1_save_change.Text = "Dəyişikləri əlavə et";
            this.button1_save_change.UseVisualStyleBackColor = true;
            this.button1_save_change.Visible = false;
            this.button1_save_change.Click += new System.EventHandler(this.button1_save_change_Click);
            // 
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(314, 260);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.PlaceholderText = "Fayl adı(.json)";
            this.textBox_file_name.Size = new System.Drawing.Size(187, 23);
            this.textBox_file_name.TabIndex = 6;
            this.textBox_file_name.TextChanged += new System.EventHandler(this.textBox_file_name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(573, 408);
            this.Controls.Add(this.textBox_file_name);
            this.Controls.Add(this.button1_save_change);
            this.Controls.Add(this.button2_searchFile);
            this.Controls.Add(this.button1_writeNewFile);
            this.Controls.Add(this.button_changeData);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4_tel);
            this.Controls.Add(this.textBox3_mail);
            this.Controls.Add(this.textBox2_surname);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1_name;
        private TextBox textBox2_surname;
        private TextBox textBox3_mail;
        private TextBox textBox4_tel;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ListBox ListBox;
        private Button button1_add;
        private Label label_message;
        private Button button1_writeNewFile;
        private Button button2_searchFile;
        private Button button_changeData;
        private Button button1_save_change;
        private TextBox textBox_file_name;
    }
}