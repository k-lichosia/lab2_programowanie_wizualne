namespace lab2_wizualne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globals.Komputer = 0;
            Globals.Monitor = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
            textBox1.Text = (Globals.Komputer + Globals.Monitor).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.ShowDialog();
            textBox1.Text = (Globals.Komputer + Globals.Monitor).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
