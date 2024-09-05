namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {

        public FrmRegistration()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = FirstName.Text.ToString();
            StudentInfoClass.LastName = LastName.Text.ToString();
            StudentInfoClass.MiddleName = MiddleName.Text.ToString();
            StudentInfoClass.Address = AddressNo.Text.ToString();
            StudentInfoClass.Program = Program.Text.ToString();
            StudentInfoClass.Age = long.Parse(Age.Text);
            StudentInfoClass.ContactNo = long.Parse(ContactNo.Text);
            StudentInfoClass.StudentNo = long.Parse(StudentNo.Text);

            FrmConfirm Confirmform = new FrmConfirm();

            var result = Confirmform.ShowDialog();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            Program.Items.AddRange(new string[] { "Computer Science", "Information Technology", "Computer Engineering", "Animation & VFX", "Game and Development" });
        }
    }
}
