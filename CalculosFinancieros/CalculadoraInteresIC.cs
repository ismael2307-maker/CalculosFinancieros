using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculadoraInteresIC : CalculoBaseInteresIC
    {
        private string capitalizacionInicial;
        private string capitalizacionConvertida;

        public CalculadoraInteresIC(double valorPresente,double valorFuturo,double periodo, string capitalizacionInicial,
            string capitalizacionConvertida)
        {
            ValorPresente = valorPresente;
            ValorFuturo = valorFuturo;
            Periodo = periodo;
            this.capitalizacionInicial = capitalizacionInicial;
            this.capitalizacionConvertida = capitalizacionConvertida;
        }
        public override double CalculoInteresIC()
        {
            double tasaConvertida = ConvertirTasa(Periodo,capitalizacionInicial,capitalizacionConvertida);
            Interes = Math.Pow(ValorFuturo / ValorPresente,1/tasaConvertida) - 1;
            return Interes;
        }

        private double ConvertirTasa(double periodo, string de, string a)
        {
            if (de == "Mensual" && a == "Semestral")
            {
                return periodo / 6;
            }
            else if (de == "Mensual" && a == "Anual")
            {
                return periodo / 12;
            }
            else if (de == "Mensual" && a == "Trimestral")
            {
                return periodo / 3;
            }
            else if (de == "Anual" && a == "Mensual")
            {
                return periodo * 12;
            }
            else if (de == "Anual" && a == "Semestral")
            {
                return periodo * 2;
            }
            else if (de == "Anual" && a == "Trimestral")
            {
                return periodo * 4;
            }
            else if (de == "Semestral" && a == "Anual")
            {
                return periodo * 2;
            }
            else if (de == "Semestral" && a == "Mensual")
            {
                return periodo / 6;
            }
            else if (de == "Semestral" && a == "Trimestral")
            {
                return periodo / 2;
            }
            else if (de == "Trimestral" && a == "Anual")
            {
                return periodo / 4 ;
            }
            else if (de == "Trimestral" && a == "Mensual")
            {
                return periodo * 3;
            }
            else if (de == "Trimestral" && a == "Semestral")
            {
                return periodo / 2;
            }
            else
            {
                return periodo;
            }
        }
    }
}
