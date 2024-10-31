using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosFinancieros
{
    public interface ICalculoInteresIC
    {
        double CalculoInteresIC();
        Object ObtenerResultadoFormateado();
    }
}
