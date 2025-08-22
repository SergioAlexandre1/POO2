using System.CodeDom.Compiler;

namespace FahrenheitToCelsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tempC;
            bool isNumeric = float.TryParse(textBox1.Text, out tempC);
            if (isNumeric)
            {
                float tempF = (float)((tempC * 1.8) + 32);
                label3.Text = $"Temperatura em °F: {tempF:F2}";
            }
            else
            {
                label1.Text = "Digite um número válido. ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
