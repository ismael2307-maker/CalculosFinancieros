using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public abstract class CalculoBaseInteresSimple : ICalculoInteresSimple
    {
        protected double ValorPresente;
        protected double ValorFuturo;
        protected double Periodo;
        protected double Interes;

        public CalculoBaseInteresSimple(double valorPresente, double valorFuturo,double periodo) 
        {
            ValorPresente = valorPresente;
            ValorFuturo = valorFuturo;
            Periodo = periodo;
        }

        public abstract void CalcularInteresSimple();
       

        public object ObtenerResultadoFormateado()
        {
            string formattedPresente = ValorPresente.ToString("N0");
            string formattedFuturo = ValorFuturo.ToString("N0");

            return new
            {
                Presente = "C$ " + formattedPresente,
                Interes = Interes,
                Periodo = Periodo,
                Futuro = "C$ "+formattedFuturo
            };
        }
    }
}
