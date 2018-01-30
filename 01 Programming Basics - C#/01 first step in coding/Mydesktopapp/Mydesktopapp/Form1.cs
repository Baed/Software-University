using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mydesktopapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = double.Parse(this.textBox1.Text);
            var num2 = double.Parse(this.textBox2.Text);

            var result = num1 + num2;
            this.textBox3.Text = result.ToString();


        }
    }
}
