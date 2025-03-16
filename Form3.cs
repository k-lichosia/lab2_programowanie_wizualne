using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2_wizualne
{
    public partial class Form3 : Form
    {
        int monitor = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case "Monitor1":
                    monitor = 100;
                    break;
                case "Monitor2":
                    monitor = 200;
                    break;
                case "Monitor3":
                    monitor = 300;
                    break;
                case "Monitor4":
                    monitor = 400;
                    break;
                case "Monitor5":
                    monitor = 500;
                    break;
                case "Monitor6":
                    monitor = 600;
                    break;
            }
            textBox1.Text = monitor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.Monitor = monitor;
            monitor = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monitor = 0;
            this.Close();
        }
    }
}
