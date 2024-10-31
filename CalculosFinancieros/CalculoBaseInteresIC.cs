using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public abstract class CalculoBaseInteresIC : ICalculoInteresIC
    {
        public double ValorPresente { get; set; }
        public double ValorFuturo { get; set; }
        public double Periodo { get; set; }
        public double Interes { get; set; }

        public abstract double CalculoInteresIC();
        

        public object ObtenerResultadoFormateado()
        {
            string formattedPresente = ValorPresente.ToString("N0");
            string formattedFuturo = ValorFuturo.ToString("N0");

            return new
            {
                Presente = "C$ "+formattedPresente,
                Futuro = "C$"+formattedFuturo,
                Periodo = Periodo,
                Interes = Interes
            };
        }
    }
}
