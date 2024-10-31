using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculosFinancieros
{
    public partial class frmInteresCompuesto : Form
    {

        public frmInteresCompuesto()
        {
            InitializeComponent();
        }
        private List<object> ResultadosFuturoIC = new List<object>();
        private void btnCalcularCF_Click(object sender, EventArgs e)
        {
            decimal valorPresente = Convert.ToDecimal(txtValorPresenteCF.Text);
            decimal interes = Convert.ToDecimal(txtTasaInteresCF.Text) / 100;
            int periodo = Convert.ToInt32(txtPeriodoCF.Text);
            string capitalizacionInicial = cmbTipoInteresInicial.SelectedItem.ToString();
            string capitalizacionFinal = cmbConvertibleA.SelectedItem.ToString();

            CalculadoraFuturoIC calculadora = new CalculadoraFuturoIC(valorPresente, interes, periodo, capitalizacionInicial, capitalizacionFinal);
            calculadora.CalculoFuturoIC();
            var resultado = calculadora.ObtenerResultadoFormateado();
            ResultadosFuturoIC.Add(resultado);
            dtgvResultadosFuturoCF.DataSource = null;
            dtgvResultadosFuturoCF.DataSource = ResultadosFuturoIC.ToList();
        }
        private List<object> ResultadosPresenteIC = new List<object>();
        private void Calcular(object sender, EventArgs e)
        {
            decimal valorFuturo = Convert.ToDecimal(txtValorFuturoCP.Text);
            decimal Interes = Convert.ToDecimal(txtTasaInteresCP.Text) / 100;
            int periodo = Convert.ToInt32(txtPeriodoCP.Text);

            string capitalizacionInicial = cmbTipoTasaFuturoIC.SelectedItem.ToString();
            string capitalizacionFinal = cmbConvertibleAFuturoIC.SelectedItem.ToString();

            CalculadoraPresenteIC calculadora = new CalculadoraPresenteIC(valorFuturo, Interes, periodo
                , capitalizacionInicial, capitalizacionFinal);
            calculadora.CalculoPresenteIC();
            var resultado = calculadora.ObtenerResultadoFormateado();
            ResultadosPresenteIC.Add(resultado);
            dtgvResultadosPresenteCP.DataSource = null;
            dtgvResultadosPresenteCP.DataSource = ResultadosPresenteIC.ToList();
        }
        List<object> ResultadosInteresIC = new List<object>();
        private void CalcularInteresIC(object sender, EventArgs e)
        {
            double valorPresente = Convert.ToDouble(txtValorPresenteCI.Text);
            double valorFuturo = Convert.ToDouble(txtValorFuturoCI.Text);
            double periodo = Convert.ToDouble(txtPeriodoCI.Text);

            string capitalizacionInicial = cmbTipoPeriodoDeIC.SelectedItem.ToString();
            string capitalizacionConvertida = cmbTipoPeriodoAIC.SelectedItem.ToString();

            CalculadoraInteresIC calculadora = new CalculadoraInteresIC(valorPresente,valorFuturo,periodo,capitalizacionInicial
                ,capitalizacionConvertida);
            calculadora.CalculoInteresIC();
            var resultado = calculadora.ObtenerResultadoFormateado();
            ResultadosInteresIC.Add(resultado);
            dtgvResultadosCI.DataSource = null;
            dtgvResultadosCI.DataSource = ResultadosInteresIC.ToList();
        }
    }
}
