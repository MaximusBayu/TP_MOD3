using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MOD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Check()
        {
            if (richTextBox3_TextChanged.TextLength > 0)
            {
                button2_Click.Enabled = true;
                button2_Click.BackColor = Color.Green;
            }
            else
            {
                button2_Click.Enabled = false;
                button2_Click.BackColor = DefaultBackColor;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
