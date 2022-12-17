namespace Healthy_Care
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resot_Click(object sender, EventArgs e)
        {

        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            if (UName.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }else if(UName.Text=="samar"&&PasswordTb.Text=="amir")
            {
                patients obj = new patients();
                obj.Show();
                this.Hide();

            }
            else
            {
                UName.Text = "";
                PasswordTb.Text = "";

            }
        }

        private void UName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}