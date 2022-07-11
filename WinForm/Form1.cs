using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Text.RegularExpressions;
using System.IO;

namespace WinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] checkMål = { "M", "Å", "L", "m", "å", "l", };
            bool checkPasses = textBox1.Text.Any(char.IsDigit);
            bool checkMålBool = textBox1.Text.Any(char.IsLetter);
            int cheer1;
            if (textBox1.Text == "") //Kontrol af input
            {
                MessageBox.Show("Please input a number or 'mål'.");
            }
            else if (Regex.IsMatch(textBox1.Text, @"[!@#$%^&*(),.?:{ }|<>]"))
            {
                MessageBox.Show("Please only use Numbers or Letters.");
                textBox1.Text = "";
            }
            else

            if (textBox1.Text.Contains(checkMål[0]) | textBox1.Text.Contains(checkMål[1]) | textBox1.Text.Contains(checkMål[2]) | textBox1.Text.Contains(checkMål[3]) | textBox1.Text.Contains(checkMål[4]) | textBox1.Text.Contains(checkMål[5]))
            {
                Score SetMål = new Score();
                return;
                


            }
            else if (checkPasses == true)
            {
                cheer1 = Int32.Parse(textBox1.Text);
                if (cheer1 < 0)
                {
                    MessageBox.Show("Shh!");
                }
                else if (cheer1 >= 1 & cheer1 <= 9)
                {
                    MessageBox.Show(String.Concat(Enumerable.Repeat("HUH! ", cheer1)));
                }
                else if (cheer1 >= 10)
                {
                    MessageBox.Show("HIGH FIVE - JUBEL!!!!");
                }

            }
        }
    }
}
