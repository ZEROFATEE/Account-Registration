using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private StudentInfoClass.DelegateText DeleProgram, DeleLastName, DeleFirstName, DeleMiddleName, DeleAddress;
        private StudentInfoClass.DelegateNumber DeleNumAge, DeleContactNo, DeleStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DeleProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DeleLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DeleFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DeleMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DeleAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);

            DeleNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DeleContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DeleStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            firstname.Text = StudentInfoClass.FirstName;
            middlename.Text = StudentInfoClass.MiddleName;
            lastname.Text = StudentInfoClass.LastName; 
            program.Text = StudentInfoClass.Program;
            address.Text = StudentInfoClass.Address;
            studentnum.Text = StudentInfoClass.StudentNo.ToString();
            contactnum.Text = StudentInfoClass.ContactNo.ToString();
            age.Text = StudentInfoClass.Age.ToString();





        }
    }
}
