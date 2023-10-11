using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Amortizacion_Prestamo.Libreria
{
    internal interface IPrestamo
    {
        float obtenerInteresAcumulado();
        int obtenerCuota();
    }
}
