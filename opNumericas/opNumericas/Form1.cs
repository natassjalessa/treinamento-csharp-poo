namespace opNumericas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.Somar();

            lblRes.Text = calc.res.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.Subtrair();

            lblRes.Text = calc.res.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.Multiplicar();

            lblRes.Text = calc.res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.Dividir();

            lblRes.Text = calc.res.ToString();
        }
    }
}