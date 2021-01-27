using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            if (number1.Equals("") || number2.Equals("") || !int.TryParse(number1, out _) || !int.TryParse(number1, out _))
            {
                MessageBox.Show("введите числа в поля ввода!", "Предупрежение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int num1 = Int32.Parse(number1);
            int num2 = Int32.Parse(number2);
            if (!button1.Enabled)
            {
                label1.Text = (num1 + num2).ToString();
            } else if (!button2.Enabled)
            {
                label1.Text = (num1 - num2).ToString();
            } else if (!button3.Enabled)
            {
                label1.Text = (num1 * num2).ToString();
            } else if (!button4.Enabled)
            {
                if(num2 == 0)
                {
                    MessageBox.Show("второе число 0б делить на 0 нельзя", "Предупрежение",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                label1.Text =Convert.ToString(Convert.ToDouble(num1) / num2);
            } else
            {
                MessageBox.Show("выберите операцию!", "Предупрежение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
