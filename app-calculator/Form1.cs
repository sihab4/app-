namespace app_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Kolom Angka tidak boleh kosong!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a + b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Kolom Angka tidak boleh kosong!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a - b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Kolom Angka tidak boleh kosong!");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a * b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Kolom Angka tidak boleh kosong!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a / b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }
    }
}