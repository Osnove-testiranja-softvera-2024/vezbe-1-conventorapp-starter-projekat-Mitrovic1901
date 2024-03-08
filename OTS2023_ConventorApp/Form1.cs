using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked)
            {
                Mass m = new Mass();
                textBox2.Text = m.Convert(double.Parse(textBox1.Text)).ToString();
                    
            }
           else
            {
                Length l = new Length();
               textBox2.Text = l.Convert(double.Parse(textBox1.Text)).ToString();
              

            }
        }
    }
}
 