using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculoAnualMeses : CalculoBase
    {
        public CalculoAnualMeses(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo/12)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }
    public class CalculoAnualAños : CalculoBase
    {
        public CalculoAnualAños(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoAnualSemestres : CalculoBase
    {
        public CalculoAnualSemestres(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 0.5)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }
    public class CalculoAnualTrimestre : CalculoBase
    {
        public CalculoAnualTrimestre(double valorPresente, double tasaInteres, double periodo) : base(valorPresente, tasaInteres, periodo * 4)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualAños : CalculoBase
    {
        public CalculoMensualAños(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 12)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualMeses : CalculoBase
    {
        public CalculoMensualMeses(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualSemestres : CalculoBase
    {
        public CalculoMensualSemestres(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 6)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoMensualTrimestres : CalculoBase
    {
        public CalculoMensualTrimestres(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 3)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralAños : CalculoBase
    {
        public CalculoSemestralAños(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 2)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralMeses : CalculoBase
    {
        public CalculoSemestralMeses(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo / 6)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralSemestres : CalculoBase
    {
        public CalculoSemestralSemestres(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoSemestralTrimestres : CalculoBase
    {
        public CalculoSemestralTrimestres(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo / 2)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralAños : CalculoBase
    {
        public CalculoTrimestralAños(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 4)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralMeses : CalculoBase
    {
        public CalculoTrimestralMeses(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo / 3)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralSemestres : CalculoBase
    {
        public CalculoTrimestralSemestres(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 2)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }

    public class CalculoTrimestralTrimestres : CalculoBase
    {
        public CalculoTrimestralTrimestres(double valorPresente, double tasaInteres, double periodo) : base(valorPresente, tasaInteres, periodo)
        {
        }

        public override void CalcularFuturo()
        {
            Futuro = ValorPresente * (1 + (TasaInteres * Periodo));
        }
    }
}
