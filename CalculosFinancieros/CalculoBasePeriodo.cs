using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculoBasePeriodo : ICalculoPeriodoIS
    {
        private double ValorPresente;
        private double ValorFuturo;
        private double TasaInteres;
        private double Periodo;

        public CalculoBasePeriodo(double valorPresente, double valorFuturo, double tasaInteres)
        {
            ValorPresente = valorPresente;
            ValorFuturo = valorFuturo;
            TasaInteres = tasaInteres / 100;
        }
        public void CalculoPeriodoIS()
        {
            Periodo = ((ValorFuturo / ValorPresente) - 1) / TasaInteres;
        }

        public object ObtenerResultadoFormateado()
        {
            string formattedPresente = ValorPresente.ToString("N0");
            string formattedFuturo = ValorFuturo.ToString("N0");
            int periodoFormateado = (int)(Periodo);

            return new
            {
                Presente = "C$ " + formattedPresente,
                Futuro = "C$ " + formattedFuturo,
                TasaInteres = TasaInteres,
                Periodo = periodoFormateado
            };
        }
    }
}
