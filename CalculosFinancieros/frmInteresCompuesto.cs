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
            double valorPresente = Convert.ToDouble(txtValorPresenteCF.Text);
            double tasaInteres = Convert.ToDouble(txtTasaInteresCF.Text);
            double periodo = Convert.ToDouble(txtPeriodoCF.Text);
            ICalcularValorFuturoIC calculo = null;

            if (rdbNoFuturoIC.Checked == true)
            {
                if (cmbInteresCF.SelectedItem != null && cmbPeriodoCF.SelectedItem != null)
                {
                    if (cmbInteresCF.SelectedItem.Equals("Anual") && cmbPeriodoCF.SelectedItem.Equals("Años"))
                    {
                        calculo = new CalculoAnualAñosSinCapitalizarIC(valorPresente,tasaInteres,periodo);
                    }
                }            
            }
            else if (rdbSiFuturoIC.Checked == true)
            {
                if (cmbInteresCF.SelectedItem != null && cmbPeriodoCF.SelectedItem != null)
                {
                    if (cmbInteresCF.SelectedItem.Equals("Mensual") && cmbPeriodoCF.SelectedItem.Equals("Años"))
                    {
                        calculo = new CalculoMensualAñosConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Mensual") && cmbPeriodoCF.SelectedItem.Equals("Meses"))
                    {
                        calculo = new CalculoMensualMesesConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Mensual") && cmbPeriodoCF.SelectedItem.Equals("Semestres"))
                    {
                        calculo = new CalculoMensualSemestresConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Mensual") && cmbPeriodoCF.SelectedItem.Equals("Trimestres"))
                    {
                        calculo = new CalculoMensualTrimestresConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Anual") && cmbPeriodoCF.SelectedItem.Equals("Años"))
                    {
                        calculo = new CalculoAnualAñosConCapitalizacion(valorPresente, tasaInteres,periodo);    
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Anual") && cmbPeriodoCF.SelectedItem.Equals("Meses"))
                    {
                        calculo = new CalculoAnualMesesConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if(cmbInteresCF.SelectedItem.Equals("Anual") && cmbPeriodoCF.SelectedItem.Equals("Semestres"))
                    {
                        calculo = new CalculoAnualSemestresConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Anual") && cmbPeriodoCF.SelectedItem.Equals("Trimestres"))
                    {
                        calculo = new CalculoAnualTrimestresConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Semestral") && cmbPeriodoCF.SelectedItem.Equals("Años"))
                    {
                        calculo = new CalculoSemestralAñosConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Semestral") && cmbPeriodoCF.SelectedItem.Equals("Meses"))
                    {
                        calculo = new CalculoSemestralMesesConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Semestral") && cmbPeriodoCF.SelectedItem.Equals("Semestres"))
                    {
                        calculo = new CalculoSemestralSemestresConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Semestral") && cmbPeriodoCF.SelectedItem.Equals("Trimestres"))
                    {
                        calculo = new CalculoSemestralTrimestresConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Trimestral") && cmbPeriodoCF.SelectedItem.Equals("Años"))
                    {
                        calculo = new CalculoTrimestralAñosConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Trimestral") && cmbPeriodoCF.SelectedItem.Equals("Meses"))
                    {
                        calculo = new CalculoTrimestralMesesConCapitalizacion(valorPresente,tasaInteres,periodo);
                    }
                    else if(cmbInteresCF.SelectedItem.Equals("Trimestral") && cmbPeriodoCF.SelectedItem.Equals("Semestres"))
                    {
                        calculo = new CalculoTrimestralSemestresConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                    else if (cmbInteresCF.SelectedItem.Equals("Trimestral") && cmbPeriodoCF.SelectedItem.Equals("Trimestres"))
                    {
                        calculo = new CalculoTrimestralTrimestresConCapitalizacion(valorPresente, tasaInteres, periodo);
                    }
                }
                
            }

            if (calculo != null)
            {
                calculo.CalcularValorFuturoIC();
                var resultado = calculo.ObtenerResultadoFormateado();
                ResultadosFuturoIC.Add(resultado);
                dtgvResultadosFuturoCF.DataSource = null;
                dtgvResultadosFuturoCF.DataSource = ResultadosFuturoIC.ToList();
            }
        }
    }
}
