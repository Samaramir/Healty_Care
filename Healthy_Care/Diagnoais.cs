using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_Care
{
    public partial class Diagnoais : Form
    {
        Funcation Con;
        int Key = 0;

        public Diagnoais()
        {
            InitializeComponent();
            Con = new Funcation();
            SowDiDiagnoais();
            GetPatients();
            GetTest();
        }
        private void SowDiDiagnoais()
        {
            String Query = "Select * from DiagnoaisTb1";
            DiagList.DataSource = Con.GetData(Query);
        }
        private void GetPatients()
        {
            String Query = "Select * from patientTb1";
            PatientCb.DisplayMember= Con.GetData(Query).Columns["patName"].ToString();
            PatientCb.ValueMember = Con.GetData(Query).Columns["patCode"].ToString();
            PatientCb.DataSource = Con.GetData(Query);
        }
        private void GetTest()
        {
            String Query = "Select * from TestTb1";
            Testcb.DisplayMember = Con.GetData(Query).Columns["TestName"].ToString();
            Testcb.DisplayMember = Con.GetData(Query).Columns["TestCode"].ToString();
            DiagList.DataSource = Con.GetData(Query);
        }
        private void GetCost()
        {
            String Query = "Select * from TestTb1  Where TestCode={0}";
            Query = String.Format(Query,Testcb.SelectedValue.ToString());
            foreach(DataRow dr in Con.GetData(Query).Rows)
            {
                CostTb.Text = dr["TestCost"].ToString();
            }
            
        }


        private void Clear()
        {


            Testcb.SelectedIndex = -1;
            PatientCb.SelectedIndex = -1;
            CostTb.Text = "";
            ResultTb.Text = "";

        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (PatientCb.SelectedIndex == -1 || CostTb.Text == "" || ResultTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {

                int name = Convert.ToInt32(PatientCb.SelectedValue.ToString());
                String DDate = DiagDateTb.Value.Date.ToString();
                int Test = Convert.ToInt32(Testcb.SelectedValue.ToString());
                int Cost = Convert.ToInt32(CostTb.Text);
                String Result = ResultTb.Text;

                String Query = "insert into DiagnosisTb1 values('{0}',{1},{2},{3},'{4}')";
                Query = String.Format(Query, name, DDate, Test, Cost, Result);
                Con.SetData(Query);
                SowDiDiagnoais();
                Clear();
                MessageBox.Show("Diagnosis Added!");

            }
        }

        private void Testcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCost();
        }
        private void DiagList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             DiagDateTb.Text = DiagList.SelectedRows[0].Cells[1].Value.ToString();
            PatientCb.SelectedItem = DiagList.SelectedRows[0].Cells[2].Value.ToString();
            Testcb.SelectedItem = DiagList.SelectedRows[0].Cells[3].Value.ToString();
            CostTb.Text = DiagList.SelectedRows[0].Cells[4].Value.ToString();
            ResultTb.Text = DiagList.SelectedRows[0].Cells[5].Value.ToString();
            if (CostTb.Text == "")
            {
                Key = 0;
            }
            else
                Key = Convert.ToInt32(DiagList.SelectedRows[0].Cells[0].Value.ToString());

        }




        private void EditB_Click(object sender, EventArgs e)
        {
            if (PatientCb.SelectedIndex == -1 || CostTb.Text == "" || ResultTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {

                int name = Convert.ToInt32(PatientCb.SelectedValue.ToString());
                String DDate = DiagDateTb.Value.Date.ToString();
                int Test = Convert.ToInt32(Testcb.SelectedValue.ToString());
                int Cost = Convert.ToInt32(CostTb.Text);
                String Result = ResultTb.Text;

                String Query = "Updata DiagnosisTb1 set DiagDate='{0}',Patient={1},Test={2},Cost={3},Result='{4}' Where DiagCode={5}";
                Query = String.Format(Query, name, DDate, Test, Cost, Result,Key);
                Con.SetData(Query);
                SowDiDiagnoais();
                Clear();
                MessageBox.Show("Diagnosis UpDate!");

            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!!");

            }
            else
            {

               

                String Query = "Delete from DiagnosisTb1 Where DiagCode={0}";
                Query = String.Format(Query, Key);
                Con.SetData(Query);
                SowDiDiagnoais();
                Clear();
                MessageBox.Show("Diagnosis Deleted!");

            }

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
