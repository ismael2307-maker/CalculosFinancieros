using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public abstract class CalculoBasePresenteIC : ICalculoPresenteIC
    {
        public decimal ValorFuturo { get; set; }
        public decimal Interes { get; set; }
        public int Periodo { get; set; }
        public decimal ValorPresente {  get; set; }
        public abstract decimal CalculoPresenteIC();
        

        public object ObtenerResultadoFormateado()
        {
            string formattedPresente = ValorPresente.ToString("N0");
            string formattedFuturo = ValorFuturo.ToString("N0");

            return new
            {
                Futuro = "C$ " + formattedFuturo,
                Interes = Interes,
                Periodo = Periodo,
                Presente = "C$ " + formattedPresente
            };
        }
    }
}
