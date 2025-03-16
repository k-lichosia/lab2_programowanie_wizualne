using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_wizualne
{
    public partial class Form2 : Form
    {
        int dysk = 0, procesor = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "procesor1":
                    procesor = 100;
                    break;
                case "procesor2":
                    procesor = 200;
                    break;
                case "procesor3":
                    procesor = 300;
                    break;
            }
            textBox1.Text = procesor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.Komputer = dysk + procesor + 1000;
            dysk = 0;
            procesor = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dysk = 0;
            procesor = 0;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) dysk = 240;
            textBox2.Text = dysk.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) dysk = 500;
            textBox2.Text = dysk.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) dysk =1000;
            textBox2.Text = dysk.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
