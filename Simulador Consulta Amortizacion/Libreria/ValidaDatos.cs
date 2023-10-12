using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Consulta_Amortizacion.Libreria
{
    internal class ValidaDatos
    {
        public string esEntero(string nombreVar, string valorVar)
        {
            if ("".Equals(valorVar))
            {
                return "Debe ingresar " + nombreVar;
            }
            else
            {
                int valorEntero;
                if (int.TryParse(valorVar, out valorEntero))
                {
                    if (valorEntero > 0)
                    {
                        return ""; //OK
                    }
                    else
                    {
                        return "Debe ingredar " + nombreVar + ">0";
                    }
                }
                else
                {
                    return "Debe ingresar " + nombreVar + " numerico entero";
                }
            }
        }
        public string esRealCorto(string  nombreVar, string valorVar)
        {
            if ("".Equals(valorVar))
            {
                return "Debe ingresar " + nombreVar;
            }
            else
            {
                float valorRealCorto;
                if (float.TryParse(valorVar, out valorRealCorto))
                {
                    if (valorRealCorto > 0)
                    {
                        return ""; // Ok Validación
                    }
                    else
                    {
                        return "Debe ingresar " + nombreVar + " > 0";
                    }
                }
                else
                {
                    return "Debe ingresar " + nombreVar + " numerico \ncon decimales";
                }
            }

        }
    }
}
