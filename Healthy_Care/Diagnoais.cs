using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_Care
{
    public partial class Diagnoais : Form
    {
        public Diagnoais()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            CostTb.Text = "";
            ResultTb.Text = "";
            Testcb.SelectedIndex = -1;
            patientcb.SelectedIndex = -1;
        }
        private void SaveB_Click(object sender, EventArgs e)
        {
            if (patientcb.SelectedIndex == -1 || CostTb.Text == "" ||ResultTb.Text == "" )
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String DDate = DateDT.Value.Date.ToString();
                int Patient= Convert.ToInt32( patientcb.SelectedValue.ToString());
                int Test = Convert.ToInt32(Testcb.SelectedValue.ToString());
                int Cost = Convert.ToInt32(CostTb.Text);
                String Result =ResultTb.Text;
                 
                String Query = "insert into Diagnos isTb values";
                Query = String.Format(Query, Patient,DDate,Test,Cost,Result);
                Clear();
                MessageBox.Show("Diagnosis Added!");

            }
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            if (patientcb.SelectedIndex == -1 || CostTb.Text == "" || ResultTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String DDate = DateDT.Value.Date.ToString();
                int Patient = Convert.ToInt32(patientcb.SelectedValue.ToString());
                int Test = Convert.ToInt32(Testcb.SelectedValue.ToString());
                int Cost = Convert.ToInt32(CostTb.Text);
                String Result = ResultTb.Text;

                String Query = "UpDate into Diagnos isTb values";
                Query = String.Format(Query, Patient, DDate, Test, Cost, Result,Key);
                Clear();
                MessageBox.Show("Diagnosis UpDste!");

            }
        }
        int Key = 0;
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (Key==0)
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String DDate = DateDT.Value.Date.ToString();
                int Patient = Convert.ToInt32(patientcb.SelectedValue.ToString());
                int Test = Convert.ToInt32(Testcb.SelectedValue.ToString());
                int Cost = Convert.ToInt32(CostTb.Text);
                String Result = ResultTb.Text;

                String Query = "Delete From Diagnos isTb values";
                Query = String.Format(Query,Key);
                Clear();
                MessageBox.Show("Diagnosis  Deleted!");

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
             Parents obj = new Parents();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
