using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculoAnualMesesPresente : CalculoBasePresente
    {
        public CalculoAnualMesesPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo / 12)
        {
        }

        

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoAnualAñosPresente : CalculoBasePresente
    {
        public CalculoAnualAñosPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }
    public class CalculoAnualSemestresPresente : CalculoBasePresente
    {
        public CalculoAnualSemestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 0.5)
        {
        }
        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoAnualTrimestresPresente : CalculoBasePresente
    {
        public CalculoAnualTrimestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo / 4)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualAñosPresente : CalculoBasePresente
    {
        public CalculoMensualAñosPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 12)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualMesesPresente : CalculoBasePresente
    {
        public CalculoMensualMesesPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualSemestresPresente : CalculoBasePresente
    {
        public CalculoMensualSemestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 6)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualTrimestresPresente : CalculoBasePresente
    {
        public CalculoMensualTrimestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 3)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralAñosPresente : CalculoBasePresente
    {
        public CalculoSemestralAñosPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 2)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralMesesPresente : CalculoBasePresente
    {
        public CalculoSemestralMesesPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo / 6)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralSemestresPresente : CalculoBasePresente
    {
        public CalculoSemestralSemestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralTrimestresPresente : CalculoBasePresente
    {
        public CalculoSemestralTrimestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo / 2)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralAñosPresente : CalculoBasePresente
    {
        public CalculoTrimestralAñosPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 4)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralMesesPresente : CalculoBasePresente
    {
        public CalculoTrimestralMesesPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo / 3)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralSemestresPresente : CalculoBasePresente
    {
        public CalculoTrimestralSemestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo * 2)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralTrimestresPresente : CalculoBasePresente
    {
        public CalculoTrimestralTrimestresPresente(double valorFuturo, double tasaInteres, double periodo) 
            : base(valorFuturo, tasaInteres, periodo)
        {
        }

        public override void CalcularValorPresente()
        {
            Presente = ValorFuturo / (1 + (TasaInteres * Periodo));
        }
    }
}
