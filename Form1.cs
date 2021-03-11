using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float v1, v2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                v1 = float.Parse(textBox1.Text);
                v2 = float.Parse(textBox2.Text);
                result = v1 + v2;
                MessageBox.Show(result.ToString());
            }

            if (radioButton2.Checked)
            {
                v1 = float.Parse(textBox1.Text);
                v2 = float.Parse(textBox2.Text);
                result = v1 - v2;
                MessageBox.Show(result.ToString());
            }

            if (radioButton3.Checked)
            {
                v1 = float.Parse(textBox1.Text);
                v2 = float.Parse(textBox2.Text);
                result = v1 * v2;
                MessageBox.Show(result.ToString());
            }
          
            if (radioButton4.Checked)
            {
                v1 = float.Parse(textBox1.Text);
                v2 = float.Parse(textBox2.Text);
                result = v1 / v2;
                MessageBox.Show(result.ToString());
            }
        }
    }
}
