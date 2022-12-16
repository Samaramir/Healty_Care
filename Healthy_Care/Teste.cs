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
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Clear()
        {
            TNameTb.Text = "";
            
            TCostTb.Text = "";
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selected a Teste!!");

            }
            else
            {

                String Query = "Delete  from Testeb1 Where patCode ={0}";
                Query = String.Format(Query, Key);
                Clear();

                MessageBox.Show(" Test Deleted!");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( TNameTb.Text == "" ||  TCostTb.Text == "" )
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String  NameTb =TNameTb.Text;
               int Cost =Convert.ToInt32(TCostTb.Text)  ;
                
                String Query = "UpDate into  Testeb1 values";
                Query = String.Format(Query,NameTb, Key);
                Clear();
                MessageBox.Show("Teste UpDated!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TCostTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String NameTb = TNameTb.Text;
                int Cost = Convert.ToInt32(TCostTb.Text);

                String Query = " insert into  Testeb1 values";
                Query = String.Format(Query, NameTb);
                Clear();
                MessageBox.Show("Teste  Saved!");

            }
        }
        int Key = 0;
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
