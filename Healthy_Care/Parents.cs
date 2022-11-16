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

            }

        }
    }
}
