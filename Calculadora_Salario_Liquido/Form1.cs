using System.Text.RegularExpressions;

namespace Calculadora_Salario_Liquido
{
    public partial class Form1 : Form
    {

        double bruto = 0;
        double fgts;
        double aliquota;
        double ir;
        double Vt;
        double bonus;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Analista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Caucular_Click(object sender, EventArgs e)
        {


        }

        private void Caucular_Click_1(object sender, EventArgs e)
        {
            if (Auxiliar.Checked)
            {
                bruto = 3300;
                aliquota = 0.15;
            }

            if (Analista.Checked)
            {
                bruto = 5000;
                aliquota = 0.275;
            }

            if (Gerente.Checked)
            {
                bruto = 16000;
                aliquota = 0.275;
            }

            Salario_Bruto.Text += bruto;

            fgts = bruto * 0.08;
            Fgts.Text += fgts;


            ir = bruto * aliquota;
            Ir.Text += ir;

            Vt = bruto * 0.06;
            vt.Text += Vt;

            bonus = Convert.ToDouble(Regex.Match(Bonus.Text, @"\d+").Value);

            Salario_Liquido.Text += bruto - fgts - ir - Vt + bonus;

        }
    }
}
