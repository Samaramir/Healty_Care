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
    public partial class Teste : Form
        
    {
        Funcation Con;
        int Key = 0;
        public Teste()
        {
            InitializeComponent();
            Con = new Funcation();
            ShowTest();
           
        }
        private void ShowTest()
        {
            String Query = "Select * from TestTb1";
            TestList.DataSource = Con.GetData(Query);
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

                String Query = " insert into  TestTb1 values('{0}','{1}')";
                Query = String.Format(Query, NameTb, Cost);
                Con.SetData(Query);
                ShowTest();
                Clear();
                MessageBox.Show("Teste  Saved!");

            }
        }



        private void Clear()
        {
            TNameTb.Text = "";

            TCostTb.Text = "";



        }


        private void TestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            TNameTb.Text = TestList.SelectedRows[0].Cells[1].Value.ToString();
            TCostTb.Text = TestList.SelectedRows[0].Cells[2].Value.ToString();
            if (TNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TestList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TCostTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {
                String NameTb = TNameTb.Text;
                int Cost = Convert.ToInt32(TCostTb.Text);

                String Query = "Update TestTb1 set TestName='{0}',TestCost='{1}' Where  TestCode={2}";
                Query = String.Format(Query, NameTb, Cost, Key);
                Con.SetData(Query);
                ShowTest();
                Clear();
                MessageBox.Show("Teste UpDated!");

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selected a Teste!!");

            }
            else
            {
                String NameTb = TNameTb.Text;
                int Cost = Convert.ToInt32(TCostTb.Text);
                String Query = "Delete  from TestTb1 Where  TestCode={0}";
                Query = String.Format(Query, Key);
                Con.SetData(Query);
                ShowTest();
                Clear();

                MessageBox.Show(" Test Deleted!");

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
            patients obj = new patients();
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


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

       
        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}

