using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public abstract class CalculoBaseFuturoIC : ICalcularValorFuturoIC
    {

        protected double ValorPresente;
        protected double TasaInteres;
        protected double Periodo;
        protected double Futuro;

        public CalculoBaseFuturoIC(double valorPresente, double tasaInteres,double periodo)
        {
            ValorPresente = valorPresente;
            TasaInteres = tasaInteres / 100;
            Periodo = periodo;

        }
        public abstract void CalcularValorFuturoIC();
        

        public object ObtenerResultadoFormateado()
        {
            string formattedP = ValorPresente.ToString("N0");
            string formattedF = Futuro.ToString("N0");

            return new
            {
                Presente = "C$ "+formattedP,
                Interes = TasaInteres * 100,
                Periodo = Periodo,
                Futuro = "C$ "+formattedF
            };
        }
    }
}
