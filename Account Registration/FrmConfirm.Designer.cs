namespace Account_Registration
{
    partial class FrmConfirm
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
            label1 = new Label();
            studentnum = new Label();
            program = new Label();
            label4 = new Label();
            firstname = new Label();
            label6 = new Label();
            label7 = new Label();
            lastname = new Label();
            middlename = new Label();
            label10 = new Label();
            label11 = new Label();
            age = new Label();
            label14 = new Label();
            contactnum = new Label();
            address = new Label();
            label17 = new Label();
            confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            // 
            // studentnum
            // 
            studentnum.AutoSize = true;
            studentnum.Location = new Point(161, 44);
            studentnum.Name = "studentnum";
            studentnum.Size = new Size(0, 15);
            studentnum.TabIndex = 1;
            // 
            // program
            // 
            program.AutoSize = true;
            program.Location = new Point(161, 78);
            program.Name = "program";
            program.Size = new Size(0, 15);
            program.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 78);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 2;
            label4.Text = "Program:";
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.Location = new Point(161, 151);
            firstname.Name = "firstname";
            firstname.Size = new Size(0, 15);
            firstname.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 151);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 4;
            label6.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 115);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 4;
            label7.Text = "Last Name:";
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.Location = new Point(161, 115);
            lastname.Name = "lastname";
            lastname.Size = new Size(0, 15);
            lastname.TabIndex = 5;
            // 
            // middlename
            // 
            middlename.AutoSize = true;
            middlename.Location = new Point(161, 189);
            middlename.Name = "middlename";
            middlename.Size = new Size(0, 15);
            middlename.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 189);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 6;
            label10.Text = "Middle Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 221);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 8;
            label11.Text = "Age:";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(161, 221);
            age.Name = "age";
            age.Size = new Size(0, 15);
            age.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 258);
            label14.Name = "label14";
            label14.Size = new Size(71, 15);
            label14.TabIndex = 10;
            label14.Text = "Contact No:";
            // 
            // contactnum
            // 
            contactnum.AutoSize = true;
            contactnum.Location = new Point(161, 258);
            contactnum.Name = "contactnum";
            contactnum.Size = new Size(0, 15);
            contactnum.TabIndex = 11;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(161, 294);
            address.Name = "address";
            address.Size = new Size(0, 15);
            address.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(42, 294);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 12;
            label17.Text = "Address:";
            // 
            // confirm
            // 
            confirm.Location = new Point(120, 356);
            confirm.Name = "confirm";
            confirm.Size = new Size(75, 23);
            confirm.TabIndex = 13;
            confirm.Text = "Submit";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // FrmConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 450);
            Controls.Add(confirm);
            Controls.Add(label17);
            Controls.Add(contactnum);
            Controls.Add(label14);
            Controls.Add(address);
            Controls.Add(age);
            Controls.Add(label11);
            Controls.Add(middlename);
            Controls.Add(label10);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(program);
            Controls.Add(label4);
            Controls.Add(studentnum);
            Controls.Add(label1);
            Name = "FrmConfirm";
            Text = "FrmConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label studentnum;
        private Label program;
        private Label label4;
        private Label firstname;
        private Label label6;
        private Label label7;
        private Label lastname;
        private Label middlename;
        private Label label10;
        private Label label11;
        private Label age;
        private Label label14;
        private Label contactnum;
        private Label address;
        private Label label17;
        private Button confirm;
    }
}