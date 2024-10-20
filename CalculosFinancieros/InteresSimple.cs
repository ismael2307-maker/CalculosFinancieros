﻿using System;
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
                    calculo = new CalculoMensualTrimestres(valorPresenteFU,tasaInteresFU,periodoFU);
                }
                else if(cmbInteres.SelectedItem.Equals("Semestral") && cmbPeriodo.SelectedItem.Equals("Años"))
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
                else if(cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Años"))
                {
                    calculo = new CalculoTrimestralAños(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Meses"))
                {
                    calculo = new CalculoTrimestralMeses(valorPresenteFU,tasaInteresFU,periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Semestres"))
                {
                    calculo = new CalculoTrimestralSemestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }
                else if (cmbInteres.SelectedItem.Equals("Trimestral") && cmbPeriodo.SelectedItem.Equals("Trimestres"))
                {
                    calculo = new CalculoTrimestralTrimestres(valorPresenteFU, tasaInteresFU, periodoFU);
                }

                if(calculo != null)
                {
                    calculo.CalcularFuturo();
                    var resultado = calculo.ObtenerResultadoFormateado();
                    ResultadosPresenteSimple.Add(resultado);
                    dtgvResultadosFuturo.DataSource = null;
                    dtgvResultadosFuturo.DataSource = ResultadosPresenteSimple.ToList();
                }
            }
        }
    }
}
