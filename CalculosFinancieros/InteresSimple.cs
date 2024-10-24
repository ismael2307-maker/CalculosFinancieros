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
    public partial class InteresSimple : Form
    {
        public InteresSimple()
        {
            InitializeComponent();
        }
        private List<object> ResultadosPresenteSimple = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorPresenteFU = Convert.ToDouble(txtValorPresente.Text);
            double tasaInteresFU = Convert.ToDouble(txtTasaInteres.Text);
            double periodoFU = Convert.ToDouble(txtPeriodo.Text);
            ICalcularValorFuturo calculo = null;

            if (cmbInteres.SelectedItem != null && cmbPeriodo.SelectedItem != null)
            {
                if (cmbInteres.SelectedItem.Equals("Anual") && cmbPeriodo.SelectedItem.Equals("Años"))
                {
                    calculo = new CalculoAnualAños(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Anual") && cmbPeriodo.SelectedItem.Equals("Meses"))
                {
                    calculo = new CalculoAnualMeses(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Anual") && cmbPeriodo.SelectedItem.Equals("Semestres"))
                {
                    calculo = new CalculoAnualSemestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Anual") && cmbPeriodo.SelectedItem.Equals("Trimestres"))
                {
                    calculo = new CalculoAnualTrimestre(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Años"))
                {
                    calculo = new CalculoMensualAños(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Meses"))
                {
                    calculo = new CalculoMensualMeses(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Semestres"))
                {
                    calculo = new CalculoMensualSemestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Trimestres"))
                {
                    calculo = new CalculoMensualTrimestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Semestral") && cmbPeriodo.SelectedItem.Equals("Años"))
                {
                    calculo = new CalculoSemestralAños(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Semestral") && cmbPeriodo.SelectedItem.Equals("Meses"))
                {
                    calculo = new CalculoSemestralMeses(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Semestral") && cmbPeriodo.SelectedItem.Equals("Semestres"))
                {
                    calculo = new CalculoSemestralSemestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Semestral") && cmbPeriodo.SelectedItem.Equals("Trimestres"))
                {
                    calculo = new CalculoSemestralTrimestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Años"))
                {
                    calculo = new CalculoTrimestralAños(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Meses"))
                {
                    calculo = new CalculoTrimestralMeses(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Semestres"))
                {
                    calculo = new CalculoTrimestralSemestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Trimestres"))
                {
                    calculo = new CalculoTrimestralTrimestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }

                if (calculo != null)
                {
                    calculo.CalcularFuturo();
                    var resultado = calculo.ObtenerResultadoFormateado();
                    ResultadosPresenteSimple.Add(resultado);
                    dtgvResultadosFuturo.DataSource = null;
                    dtgvResultadosFuturo.DataSource = ResultadosPresenteSimple.ToList();
                }
            }
        }
        //*********************************************************************************
        private List<object> ResultadosPresente = new List<object>();
        private void btnCalcularP_Click(object sender, EventArgs e)
        {
            double valorFuturo = Convert.ToDouble(txtValorFuturo.Text);
            double tasaInteres = Convert.ToDouble(txtTasaInteresP.Text);
            double periodo = Convert.ToDouble(txtPeriodoP.Text);

            ICalcularValorPresente calculoPresente = null;

            if (cmbInteresP.SelectedItem != null && cmbPeriodoP.SelectedItem != null)
            {
                if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                {
                    calculoPresente = new CalculoAnualMesesPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                {
                    calculoPresente = new CalculoAnualAñosPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                {
                    calculoPresente = new CalculoAnualSemestresPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                {
                    calculoPresente = new CalculoMensualAñosPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                {
                    calculoPresente = new CalculoMensualMesesPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                {
                    calculoPresente = new CalculoMensualSemestresPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Trimestral"))
                {
                    calculoPresente = new CalculoMensualTrimestresPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                {
                    calculoPresente = new CalculoSemestralAñosPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                {
                    calculoPresente = new CalculoSemestralMesesPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                {
                    calculoPresente = new CalculoSemestralSemestresPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                {
                    calculoPresente = new CalculoSemestralTrimestresPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                {
                    calculoPresente = new CalculoTrimestralAñosPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                {
                    calculoPresente = new CalculoTrimestralMesesPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                {
                    calculoPresente = new CalculoTrimestralSemestresPresente(valorFuturo, tasaInteres, periodo);
                }
                else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                {
                    calculoPresente = new CalculoTrimestralTrimestresPresente(valorFuturo, tasaInteres, periodo);
                }

                if (calculoPresente != null)
                {
                    calculoPresente.CalcularValorPresente();
                    var resultadoPresente = calculoPresente.ObtenerResultadoFormateado();
                    ResultadosPresente.Add(resultadoPresente);

                    dtgvResultadoP.DataSource = null;
                    dtgvResultadoP.DataSource = ResultadosPresente.ToList();
                }

            }
        }

        private void InteresSimple_Load(object sender, EventArgs e)
        {
            cmbInteresP.Items.Add("Anual");
            cmbInteresP.Items.Add("Mensual");
            cmbInteresP.Items.Add("Semestral");
            cmbInteresP.Items.Add("Trimestral");

            cmbPeriodoP.Items.Add("Años");
            cmbPeriodoP.Items.Add("Meses");
            cmbPeriodoP.Items.Add("Semestres");
            cmbPeriodoP.Items.Add("Trimestres");

            cmbInteresP.SelectedIndex = 0;
            cmbPeriodoP.SelectedIndex = 0;
        }

        private List<object> ResultadoInteresSimple = new List<object>();
        private void btnCalcularInteresSimple_Click(object sender, EventArgs e)
        {
            double valorFuturoIN = Convert.ToDouble(txtValorFuturoI.Text);
            double valorPresenteIN = Convert.ToDouble(txtValorPresenteI.Text);
            double periodoIN = Convert.ToDouble(txtPeriodoI.Text);
            ICalculoInteresSimple calculoInteres = null;

            if (cmbTipoTasaInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
            {
                calculoInteres = new CalculoAnualMesesInteresSimple(valorPresenteIN, valorFuturoIN, periodoIN);
            }
            else if (cmbTipoTasaInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoInteresSimple.SelectedItem.Equals("Meses"))
            {
                calculoInteres = new CalculoAnualMesesInteresSimple(valorPresenteIN,valorFuturoIN,periodoIN);
            }
            

            if (calculoInteres != null)
            {
                calculoInteres.CalcularInteresSimple();
                ResultadoInteresSimple.Add(calculoInteres.ObtenerResultadoFormateado());
                dtgvResultadosInteresSimple.DataSource = null;
                dtgvResultadosInteresSimple.DataSource = ResultadoInteresSimple.ToList();
            }
        }
    }
}
