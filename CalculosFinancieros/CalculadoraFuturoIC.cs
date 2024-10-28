using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculadoraFuturoIC : CalculoBaseFuturoIC
    {
        private string capitalizacionInicial;
        private string capitalizacionConvertida;

        public CalculadoraFuturoIC(decimal valorPresente, decimal interes, int periodo, string capitalizacionInicial,
            string capitalizacionConvertida) 
        {
            ValorPresente = valorPresente;
            Interes = interes;
            Periodo = periodo;
            this.capitalizacionInicial = capitalizacionInicial;
            this.capitalizacionConvertida = capitalizacionConvertida;
        }

        public override decimal CalculoFuturoIC()
        {
            decimal tasaConvertida = ConvertirTasa(Interes, capitalizacionInicial, capitalizacionConvertida);
            ValorFuturo = ValorPresente * (decimal)Math.Pow(1 + (double)tasaConvertida, Periodo);
            return ValorFuturo;
        }

        private decimal ConvertirTasa(decimal interes, string de, string a)
        {
            if(de == "Mensual" && a == "Semestral")
            {
                return interes * 6;
            }
            else if (de == "Mensual" && a == "Anual")
            {
                return interes * 12;
            }
            else if (de == "Mensual" && a == "Trimestral")
            {
                return interes * 3;
            }
            else
            {
                return interes;
            }
        }
    }
}
