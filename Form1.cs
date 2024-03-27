namespace Testes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtPriNum.Text);
            int num2 = int.Parse(txtSegNum.Text);

            int result = num1 + num2;

            txtResult.Text = result.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtPriNum.Text);
            int num2 = int.Parse(txtSegNum.Text);

            int result = num1 - num2;

            txtResult.Text = result.ToString();
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtPriNum.Text);
            int num2 = int.Parse(txtSegNum.Text);

            int result = num1 * num2;

            txtResult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtPriNum.Text);
            int num2 = int.Parse(txtSegNum.Text);

            int result = num1 / num2;

            txtResult.Text = result.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPriNum.Text = "";
            txtSegNum.Text = "";
            
        }
    }
}