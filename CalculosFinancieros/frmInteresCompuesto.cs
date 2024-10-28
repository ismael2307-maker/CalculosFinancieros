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

            CalculadoraFuturoIC calculadora = new CalculadoraFuturoIC(valorPresente,interes,periodo,capitalizacionInicial,capitalizacionFinal);
            calculadora.CalculoFuturoIC();
            var resultado = calculadora.ObtenerResultadoFormateado();
            ResultadosFuturoIC.Add(resultado);
            dtgvResultadosFuturoCF.DataSource = null;
            dtgvResultadosFuturoCF.DataSource = ResultadosFuturoIC.ToList();
        }
    }
}
