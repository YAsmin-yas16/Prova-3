using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperação
{
    public partial class Form2 : Form
    {
        int i = 0;
        int a = 0;
        int b = 0;
        int d = 0;
        int c = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo;
            arquivo = new StreamWriter("Carros.txt");
            arquivo.WriteLine ( checkBox2 );
            arquivo.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
                if (radioButton2.Checked == false)
                    MessageBox.Show("Selecione uma dos motores");

            if (ComboBox.CheckForIllegalCrossThreadCalls == false)
                MessageBox.Show("selecione um carro");

            if (radioButton1.Checked)
            {
                i = 200;
            }
            else if (radioButton2.Checked)
            {
                a = 100;
            }
            if (checkBox1.Checked)
            {
                b = 60;
            }
            if (checkBox2.Checked)
            {
                d = 100;
            }
            if (checkBox3.Checked)
            {
                c = 100;
            }

            label1.Text = (i + a + b + d + c).ToString();
        }
    }
}
