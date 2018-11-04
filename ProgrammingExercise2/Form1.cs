using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Blue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
            }
            if (!checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Bold);
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);
            }
            if (!checkBox2.Checked)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Italic);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);
            }
            if (!checkBox3.Checked)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Underline);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(listBox1.SelectedItem.ToString(), label1.Font.Size, label1.Font.Style);
        }

        
    }
}
