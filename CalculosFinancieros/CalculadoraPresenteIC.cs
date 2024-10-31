using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculadoraPresenteIC : CalculoBasePresenteIC
    {
        private string capitalizacionInicial;
        private string capitalizacionConvertida;

        public CalculadoraPresenteIC(decimal valorFuturo, decimal interes, int periodo, string capitalizacionInicial,
            string capitalizacionConvertida)
        {
            ValorFuturo = valorFuturo;
            Interes = interes;
            Periodo = periodo;
            this.capitalizacionInicial = capitalizacionInicial;
            this.capitalizacionConvertida = capitalizacionConvertida;
        }

        public override decimal CalculoPresenteIC()
        {
            decimal tasaConvertida = ConvertirTasa(Interes,capitalizacionInicial,capitalizacionConvertida);
            ValorPresente = ValorFuturo / (decimal)Math.Pow((double)(1 + tasaConvertida), Periodo);
            return ValorPresente;
        }

        private decimal ConvertirTasa(decimal interes, string de, string a)
        {
            if (de == "Mensual" && a == "Semestral")
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
            else if (de == "Anual" && a == "Mensual")
            {
                return interes / 12;
            }
            else if (de == "Anual" && a == "Semestral")
            {
                return interes / 2;
            }
            else if (de == "Anual" && a == "Trimestral")
            {
                return interes / 4;
            }
            else if (de == "Semestral" && a == "Anual")
            {
                return interes * 2;
            }
            else if (de == "Semestral" && a == "Mensual")
            {
                return interes / 6;
            }
            else if (de == "Semestral" && a == "Trimestral")
            {
                return interes / 2;
            }
            else if (de == "Trimestral" && a == "Anual")
            {
                return interes * 4;
            }
            else if (de == "Trimestral" && a == "Mensual")
            {
                return interes / 3;
            }
            else if (de == "Trimestral" && a == "Semestral")
            {
                return interes * 2;
            }
            else
            {
                return interes;
            }
        }
    }
}
