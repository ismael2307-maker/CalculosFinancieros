using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public class CalculoAnualMesesInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoAnualMesesInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo /12)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoAnualAñosInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoAnualAñosInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoAnualSemestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoAnualSemestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 2)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoAnualTrimestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoAnualTrimestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo / 4)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoMensualAñosInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoMensualAñosInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 12)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoMensualMesesInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoMensualMesesInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoMensualSemestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoMensualSemestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 6)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoMensualTrimestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoMensualTrimestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 3)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoSemestralAñosInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoSemestralAñosInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 2)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoSemestralMesesInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoSemestralMesesInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo / 6)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoSemestralSemestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoSemestralSemestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo)
        {
        }

        public override void CalcularInteresSimple()
        {
            throw new NotImplementedException();
        }
    }

    public class CalculoSemestralTrimestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoSemestralTrimestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo / 2)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoTrimestralAñosInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoTrimestralAñosInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 4)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoTrimestralMesesInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoTrimestralMesesInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo / 3)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoTrimestralSemestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoTrimestralSemestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo * 2)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }

    public class CalculoTrimestralTrimestresInteresSimple : CalculoBaseInteresSimple
    {
        public CalculoTrimestralTrimestresInteresSimple(double valorPresente, double valorFuturo, double periodo) 
            : base(valorPresente, valorFuturo, periodo)
        {
        }

        public override void CalcularInteresSimple()
        {
            Interes = ((ValorFuturo / ValorPresente) - 1) / Periodo;
        }
    }
}
