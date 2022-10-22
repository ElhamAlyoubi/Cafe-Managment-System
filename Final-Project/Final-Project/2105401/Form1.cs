using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2105401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            txtCake1.Enabled = false;
            if (checkBox9.Checked == true)
                txtCake1.Enabled = true;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            txtCake2.Enabled = false;
            if (checkBox10.Checked == true)
                txtCake2.Enabled = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            txtCake3.Enabled = false;
            if (checkBox11.Checked == true)
                txtCake3.Enabled = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            txtCake4.Enabled = false;
            if (checkBox12.Checked == true)
                txtCake4.Enabled = true;

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            txtCake5.Enabled = false;
            if (checkBox13.Checked == true)
                txtCake5.Enabled = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            txtCake6.Enabled = false;
            if (checkBox14.Checked == true)
                txtCake6.Enabled = true;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            txtCake7.Enabled = false;
            if (checkBox15.Checked == true)
                txtCake7.Enabled = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            txtCake8.Enabled = false;
            if (checkBox16.Checked == true)
                txtCake8.Enabled = true;
        }

        private void txtCake1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCake3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCake8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double Cake1 = Convert.ToDouble(txtCake1.Text);
            double Cake2 = Convert.ToDouble(txtCake2.Text);
            double Cake3 = Convert.ToDouble(txtCake3.Text);
            double Cake4 = Convert.ToDouble(txtCake4.Text);
            double Cake5 = Convert.ToDouble(txtCake5.Text);
            double Cake6 = Convert.ToDouble(txtCake6.Text);
            double Cake7 = Convert.ToDouble(txtCake7.Text);
            double Cake8 = Convert.ToDouble(txtCake8.Text);
            double Cake1_Cost = 17;
            double Cake2_Cost = 15; 
            double Cake3_Cost = 20;
            double Cake4_Cost = 24;
            double Cake5_Cost = 22;
            double Cake6_Cost = 19;
            double Cake7_Cost = 23;
            double Cake8_Cost = 23;
            double CostOfCakes = (Cake1_Cost * Cake1) +(Cake2_Cost * Cake2) + (Cake3_Cost * Cake3) +
                (Cake4_Cost * Cake4) + (Cake5_Cost * Cake5) + (Cake6_Cost * Cake6) +
                (Cake7_Cost * Cake7) + (Cake8_Cost * Cake8);
            CostCakestextBox.Text = CostOfCakes.ToString();

        }
    }
}
