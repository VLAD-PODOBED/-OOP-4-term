using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1TextCulculator
{
    public partial class CulcForm : Form , ICulculator
    {
        public CulcForm()
        {
            InitializeComponent();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Length != 1) throw new Exception("Вы должны указать 1 символ для индекса");
                if (textBox3.Text.Length == 0) throw new Exception("Вы можете посчитать нулевую строку");

                textBox12.Text = Culculator.FindIndex(textBox3.Text, textBox6.Text);
                textBox7.Text = Culculator.FindGlasniy(textBox3.Text);
                textBox11.Text = Culculator.FindSoglasniy(textBox3.Text);
                textBox10.Text = Culculator.CulcSentensice(textBox3.Text);
                textBox9.Text = Culculator.CulcWords(textBox3.Text);
                textBox8.Text = textBox3.Text.Length.ToString();
            }
            catch (Exception Myexceptiom)
            {
                MessageBox.Show(Myexceptiom.Message);               
            }
            finally 
            {
                Console.WriteLine("good or no good");
            }   
        }

        public void button1_Changer_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;

            if (textBox2.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                textBox3.Text = Culculator.ChengerText(textBox3.Text,textBox2.Text,textBox4.Text);
            }

            if (textBox5.Text.Length > 0)
            {
                textBox3.Text = Culculator.DeleteText(textBox3.Text, textBox5.Text);
                textBox3.Text = textBox3.Text.Replace(textBox5.Text, "");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
