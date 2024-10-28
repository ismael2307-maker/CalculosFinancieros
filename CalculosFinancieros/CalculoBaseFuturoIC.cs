using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public abstract class CalculoBaseFuturoIC : ICalculoFuturoIC
    {
        public decimal ValorPresente {  get; set; }
        public decimal Interes {  get; set; }
        public int Periodo { get;set; }
        public decimal ValorFuturo {  get; protected set; }

        public abstract decimal CalculoFuturoIC();
        
        public object ObtenerResultadoFormateado()
        {
            string formattedPresente = ValorPresente.ToString("N0");
            string formattedFuturo = ValorFuturo.ToString("N0");

            return new
            {
                Presente = "C$ "+formattedPresente,
                Interes = Interes,
                Periodo = Periodo,
                Futuro = "C$ "+formattedFuturo
            };
        }
    }
}
