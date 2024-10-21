using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public abstract class CalculoBasePresente : ICalcularValorPresente
    {
        protected double ValorFuturo;
        protected double TasaInteres;
        protected double Periodo;
        protected double Presente;

        public CalculoBasePresente(double valorFuturo, double tasaInteres, double periodo)
        {
            ValorFuturo = valorFuturo;
            TasaInteres = tasaInteres / 100;
            Periodo = periodo;
        }

        public abstract void CalcularValorPresente();
        
        public object ObtenerResultadoFormateado()
        {
            string formattedVF = ValorFuturo.ToString("N0");
            string formattedVP = Presente.ToString("N0");

            return new
            {
                Futuro = "C$" + formattedVF,
                Interes = TasaInteres,
                Periodo = Periodo,
                Presente = formattedVP
            };
        }
    }
}
