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
    public partial class patients : Form
    {
        Funcation Con;
        int Key = 0;
        public patients()
        {
            InitializeComponent();
            Con = new Funcation();
            Showpatients();


        }
        private void Showpatients()
        {
            String Query = "Select * from patientTb1";
            patientsList.DataSource = Con.GetData(Query);
        }
        
        
        private void SaveBox_Click(object sender, EventArgs e)
        {
            if (PatinName.Text == "" || Phonenum.Text == "" || PatAddres.Text == "" || gander.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String Patiens = PatinName.Text;
                String Gander = gander.SelectedItem.ToString();
                String Data = DatBarth.ToString();
                String Phone = Phonenum.Text;
                String Address = PatAddres.Text;
                String Query = "insert into patientTb1 values('{0}','{1}','{2}','{3}','{4}')";
                Query = String.Format(Query, Patiens, Gander, Data, Phone, Address);
                Con.SetData(Query);
                Showpatients();
                Clear();
                MessageBox.Show("Patiens Added!");

            }

        }


        private void patientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatinName.Text = patientsList.SelectedRows[0].Cells[1].Value.ToString();
            gander.SelectedItem = patientsList.SelectedRows[0].Cells[2].Value.ToString();
            DatBarth.Text = patientsList.SelectedRows[0].Cells[3].Value.ToString();
            Phonenum.Text = patientsList.SelectedRows[0].Cells[4].Value.ToString();
            PatAddres.Text = patientsList.SelectedRows[0].Cells[5].Value.ToString();
            if (PatinName.Text == "")
            {
                Key = 0;
            }
            else
                Key = Convert.ToInt32(patientsList.SelectedRows[0].Cells[0].Value.ToString());

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (PatinName.Text == "" || Phonenum.Text == "" || PatAddres.Text == "" || gander.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String Patiens = PatinName.Text;
                string Gander = gander.SelectedItem.ToString();
                String Data = DatBarth.ToString();
                String Phone = Phonenum.Text;
                String Address = PatAddres.Text;
                String Query = "UpDate PatientTb1 set patName='{0},patGen='{1},patDOB='{2},patPhone='{3},patAdd='{4},Where patCode='{5}";
                Query = String.Format(Query, Patiens, Gander, Data, Phone, Address, Key);
                Con.SetData(Query);
                Showpatients();
                Clear();
                MessageBox.Show("Patiens UpDated!");

            }
        }


        private void Clear()
        {
            PatinName.Text = "";
            gander.SelectedIndex = -1;
            Phonenum.Text = "";
            PatAddres.Text = "";


        }
        private void DeletBox_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selected a Patinet!!!");

            }
            else
            {

                String Query = "Delete  from patienTb1 Where patCode ={0}";
                Query = String.Format(Query, Key);
                Con.SetData(Query);
                Showpatients();
                Clear();

                MessageBox.Show("Patiens Deleted!");

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            patients obj = new patients();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
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



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Parents_Load(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

         }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PatinName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatBarth_ValueChanged(object sender, EventArgs e)
        {

        }
        private void gander_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
