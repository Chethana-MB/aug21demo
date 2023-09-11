using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filedemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }
        private void button2_Click(object sender,EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }
        private void button3_Click(object sender,EventArgs e)
        {
            DialogResult res = fontDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;

            }
        }
    }
}
