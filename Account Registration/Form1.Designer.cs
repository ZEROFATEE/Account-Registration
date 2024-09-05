namespace Account_Registration
{
    partial class FrmRegistration
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
            label1 = new Label();
            StudentNo = new TextBox();
            LastName = new TextBox();
            label2 = new Label();
            Age = new TextBox();
            label3 = new Label();
            ContactNo = new TextBox();
            label4 = new Label();
            FirstName = new TextBox();
            label5 = new Label();
            MiddleName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Program = new ComboBox();
            AddressNo = new ListBox();
            label8 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            // 
            // StudentNo
            // 
            StudentNo.Location = new Point(23, 44);
            StudentNo.Name = "StudentNo";
            StudentNo.Size = new Size(223, 23);
            StudentNo.TabIndex = 1;
            // 
            // LastName
            // 
            LastName.Location = new Point(23, 110);
            LastName.Name = "LastName";
            LastName.Size = new Size(223, 23);
            LastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 92);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // Age
            // 
            Age.Location = new Point(23, 163);
            Age.Name = "Age";
            Age.Size = new Size(223, 23);
            Age.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 145);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Age:";
            // 
            // ContactNo
            // 
            ContactNo.Location = new Point(270, 163);
            ContactNo.Name = "ContactNo";
            ContactNo.Size = new Size(250, 23);
            ContactNo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 145);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Contact No:";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(270, 110);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(250, 23);
            FirstName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 92);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "First Name:";
            // 
            // MiddleName
            // 
            MiddleName.Location = new Point(543, 110);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(223, 23);
            MiddleName.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 92);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 10;
            label6.Text = "Middle Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 26);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 12;
            label7.Text = "Program";
            // 
            // Program
            // 
            Program.FormattingEnabled = true;
            Program.Location = new Point(270, 44);
            Program.Name = "Program";
            Program.Size = new Size(334, 23);
            Program.TabIndex = 13;
            // 
            // AddressNo
            // 
            AddressNo.AllowDrop = true;
            AddressNo.FormattingEnabled = true;
            AddressNo.ItemHeight = 15;
            AddressNo.Location = new Point(23, 212);
            AddressNo.Name = "AddressNo";
            AddressNo.Size = new Size(743, 199);
            AddressNo.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 189);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 15;
            label8.Text = "Address";
            // 
            // button1
            // 
            button1.Location = new Point(356, 418);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(668, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(AddressNo);
            Controls.Add(Program);
            Controls.Add(label7);
            Controls.Add(MiddleName);
            Controls.Add(label6);
            Controls.Add(FirstName);
            Controls.Add(label5);
            Controls.Add(ContactNo);
            Controls.Add(label4);
            Controls.Add(Age);
            Controls.Add(label3);
            Controls.Add(LastName);
            Controls.Add(label2);
            Controls.Add(StudentNo);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "Form1";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StudentNo;
        private TextBox LastName;
        private Label label2;
        private TextBox Age;
        private Label label3;
        private TextBox ContactNo;
        private Label label4;
        private TextBox FirstName;
        private Label label5;
        private TextBox MiddleName;
        private Label label6;
        private Label label7;
        private ComboBox Program;
        private ListBox AddressNo;
        private Label label8;
        private Button button1;
        private ComboBox comboBox1;
    }
}
