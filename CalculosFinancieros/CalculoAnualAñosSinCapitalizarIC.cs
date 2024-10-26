using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculoAnualAñosSinCapitalizarIC : CalculoBaseFuturoIC
    {
        public CalculoAnualAñosSinCapitalizarIC(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo)
        {
        }

        public override void CalcularValorFuturoIC()
        {
           Futuro = ValorPresente * Math.Pow(1 + TasaInteres,Periodo);
        }
    }
    //Tasa de interes anual
    public class CalculoMensualAñosConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoMensualAñosConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 12, periodo * 12)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Interes Anual
    public class CalculoMensualMesesConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoMensualMesesConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 12, periodo)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Interes Anual
    public class CalculoMensualSemestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoMensualSemestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 12, periodo * 6)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Interes Anual
    public class CalculoMensualTrimestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoMensualTrimestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo * 3)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }

    public class CalculoAnualAñosConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoAnualAñosConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }

    public class CalculoAnualMesesConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoAnualMesesConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo / 12)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }

    public class CalculoAnualSemestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoAnualSemestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo / 2)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }

    public class CalculoAnualTrimestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoAnualTrimestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres, periodo / 4)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoSemestralAñosConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoSemestralAñosConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres /2 , periodo * 2)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoSemestralMesesConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoSemestralMesesConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 2, periodo / 6)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoSemestralSemestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoSemestralSemestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 2, periodo)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoSemestralTrimestralConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoSemestralTrimestralConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 2, periodo / 2)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoTrimestralAñosConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoTrimestralAñosConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 4, periodo * 4)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoTrimestralMesesConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoTrimestralMesesConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 4, periodo / 3)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoTrimestralSemestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoTrimestralSemestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 4, periodo * 2)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }
    //Tasa Anual
    public class CalculoTrimestralTrimestresConCapitalizacion : CalculoBaseFuturoIC
    {
        public CalculoTrimestralTrimestresConCapitalizacion(double valorPresente, double tasaInteres, double periodo) 
            : base(valorPresente, tasaInteres / 4, periodo)
        {
        }

        public override void CalcularValorFuturoIC()
        {
            Futuro = ValorPresente * Math.Pow(1 + TasaInteres, Periodo);
        }
    }







}
