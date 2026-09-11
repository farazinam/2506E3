namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(inp1.Text);
            decimal num2 = decimal.Parse(inp2.Text);

            decimal res = num1 + num2;

            label5.Text = res.ToString();

            richTextBox1.Text += $"Addition of {num1} and {num2} is {res.ToString()} \n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(inp1.Text);
            decimal num2 = decimal.Parse(inp2.Text);

            decimal res = num1 - num2;

            label5.Text = res.ToString();

            richTextBox1.Text += $"Subtraction of {num1} and {num2} is {res.ToString()} \n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(inp1.Text);
            decimal num2 = decimal.Parse(inp2.Text);

            decimal res = num1 * num2;

            label5.Text = res.ToString();

            richTextBox1.Text += $"Multiplication of {num1} and {num2} is {res.ToString()} \n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(inp1.Text);
            decimal num2 = decimal.Parse(inp2.Text);

            decimal res = num1 / num2;

            label5.Text = res.ToString();

            richTextBox1.Text += $"Division of {num1} and {num2} is {res.ToString()} \n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inp1.Text = "";
            inp2.Text = "";
            label5.Text = "";
        }

        private void inp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }
    }
}
