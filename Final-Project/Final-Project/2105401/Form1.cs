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
            if (checkBox3.Checked == true)
            {
              
                textBox3.Clear();
                textBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            {
                txtCake1.Clear();
                txtCake1.Enabled = true;
            } 
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            txtCake2.Enabled = false;
            if (checkBox10.Checked == true)
                txtCake2.Clear(); txtCake2.Enabled = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            txtCake3.Enabled = false;
            if (checkBox11.Checked == true)
                txtCake3.Clear(); txtCake3.Enabled = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            txtCake4.Enabled = false;
            if (checkBox12.Checked == true)
                txtCake4.Clear(); txtCake4.Enabled = true;

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            txtCake5.Enabled = false;
            if (checkBox13.Checked == true)
                txtCake5.Clear(); txtCake5.Enabled = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            txtCake6.Enabled = false;
            if (checkBox14.Checked == true)
                txtCake6.Clear(); txtCake6.Enabled = true;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            txtCake7.Enabled = false;
            if (checkBox15.Checked == true)
                txtCake7.Clear(); txtCake7.Enabled = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            txtCake8.Enabled = false;
            if (checkBox16.Checked == true)
                txtCake8.Clear(); txtCake8.Enabled = true;
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
            //  Drinks
            double deink1 = double.Parse(textBox1.Text);
          
            double deink2 = double.Parse(textBox2.Text); 
            double deink3 = double.Parse(textBox3.Text); 
            double deink4 = double.Parse(textBox4.Text); 
            double deink5 = double.Parse(textBox5.Text); 
            double deink6 = double.Parse(textBox6.Text); 
            double deink7 = double.Parse(textBox7.Text); 
            double deink8 = double.Parse(textBox8.Text); 

            double drink1Cost = 10.1;
            double drink2Cost = 10.00;
            double drink3Cost = 10.65;
            double drink4Cost = 10.2;
            double drink5Cost = 10.1;
            double drink6Cost = 10.90;
            double drink7Cost = 10.8;
            double drink8Cost = 10.5;

            double CostOfCakes = (Cake1_Cost * Cake1) +(Cake2_Cost * Cake2) + (Cake3_Cost * Cake3) +
                (Cake4_Cost * Cake4) + (Cake5_Cost * Cake5) + (Cake6_Cost * Cake6) +
                (Cake7_Cost * Cake7) + (Cake8_Cost * Cake8);
            CostCakestextBox.Text = "ر.س" + CostOfCakes.ToString();

            double cost = ((deink1 * drink1Cost) +
                           (deink2 * drink2Cost) +
                           (deink3 * drink3Cost) +
                           (deink4 * drink4Cost) +
                           (deink5 * drink5Cost) +
                           (deink6 * drink6Cost) +
                           (deink7 * drink7Cost) +
                           (deink8 * drink8Cost));
                    CostDrinkstextBox.Text= "ر.س"+cost.ToString() ;

            Double ServiceCharge = 5.50;
            ServiceChargetextBox.Text = "ر.س" + ServiceCharge.ToString();

            Double Tax = 10.5;
            TaxtextBox.Text = "ر.س" + Tax.ToString();

            
            
            Double SubTotal1 = cost + CostOfCakes + ServiceCharge;
            SubTotaltextBox.Text = "ر.س" + SubTotal1.ToString();

            Double Total = cost + CostOfCakes + Tax + ServiceCharge ;
            
            TotaltextBox.Text = "ر.س" + Total.ToString();


            //Bili
            //D
            label2.Text = "**Drinks**";
          //  label2.Text +="\n" +namedrinks+"         "+textBox1.Text;
             if(checkBox1.Checked == true)
            {
             label2.Text += "\n" + checkBox1.Text + "         " +textBox1.Text;
            }
             if (checkBox2.Checked == true)
            {
                label2.Text += "\n" + checkBox2.Text + "         " +textBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                label2.Text += "\n" + checkBox3.Text + "         " +textBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                label2.Text += "\n" + checkBox4.Text + "         " + textBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                label2.Text += "\n" + checkBox5.Text + "         " + textBox5.Text;
            }
            if (checkBox6.Checked == true)
            {
                label2.Text += "\n" + checkBox6.Text + "         " + textBox6.Text;
            }
            if (checkBox7.Checked == true)
            {
                label2.Text += "\n" + checkBox7.Text + "         " + textBox7.Text;
            }
            if (checkBox8.Checked == true)
            {
                label2.Text += "\n" + checkBox8.Text + "         " + textBox8.Text;
            }
           




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
               
               textBox1.Clear();
                textBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
               
                textBox2.Clear();
                textBox2.Enabled = true;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
               
                textBox4.Clear();
                textBox4.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                
                textBox5.Clear();
                textBox5.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
               
                textBox6.Clear();
                textBox6.Enabled = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
               ;
                textBox7.Clear();
                textBox7.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                
                textBox8.Clear();
                textBox8.Enabled = true;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }
    }
}
