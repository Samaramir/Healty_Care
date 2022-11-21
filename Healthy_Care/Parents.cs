using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_Care
{
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatinName.Text == "" || Phonenum.Text == "" || PatAddres.Text == "" || Gander1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String Patiens = PatinName.Text;
                String Gander = Gander1.SelectedItem.ToString();
                String Data = DatBarth.ToString();
                String Phone = Phonenum.Text;
                String Address = PatAddres.Text;
                String Query = "UpDate into patientb1 values";
                Query = String.Format(Query, Patiens, Gander, Data, Phone, Address,Key);
                Clear();
                MessageBox.Show("Patiens UpDated!");

            }
        }

        private void Parents_Load(object sender, EventArgs e)
        {

        }

        private void SaveBox_Click(object sender, EventArgs e)
        { 
            if(PatinName.Text=="" || Phonenum.Text==""|| PatAddres.Text=="" || Gander1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String Patiens = PatinName.Text;
                String Gander = Gander1.SelectedItem.ToString();
                String Data = DatBarth.ToString();
                String Phone = Phonenum.Text;
                String Address  = PatAddres.Text;
                String Query = "insert into patientb1 values";
                Query = String.Format(Query, Patiens, Gander, Data, Phone, Address);
                Clear();
                MessageBox.Show("Patiens Added!");

            }

        }
        int Key = 0;

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           



         }
        private void Clear()
        {
            PatinName.Text = "";
            Gander1.SelectedIndex = -1;
                Phonenum.Text = "";
            PatAddres.Text = "";


        }
        private void DeletBox_Click(object sender, EventArgs e)
        {
            if (Key ==0)
            {
                MessageBox.Show("Selected a Patinet!!!");

            }
            else
            {
                
                String Query = "Delete  from patientb1 Where patCode ={0}";
                Query = String.Format(Query, Key);
                Clear();

                MessageBox.Show("Patiens Deleted!");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Parents obj = new Parents();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Teste obj = new Teste();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Diagnoais obj = new Diagnoais();
            obj.Show();
            this.Hide();
        }
    }
}
