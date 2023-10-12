using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Amortizacion_Prestamo.Libreria
{
    internal class Amortizacion
    {
        #region"Atributos"
        private int _idA;
        private Prestamo _prestamo;
        #endregion
        #region"Constructores"
        public Amortizacion()
        {
            _idA = 0;
            _prestamo = new Prestamo();
        }
        public Amortizacion (int idA, Prestamo prestamo)
        {
            _idA = idA;
            _prestamo = prestamo;
        }
        #endregion
        #region"Propiedades"
        public int IdA
        {
            set { _idA = value; }
            get { return _idA; }
        }
        public Prestamo Prestamo
        {
            set { _prestamo = value; }
            get { return _prestamo; }
        }
        #endregion
        #region"Metodos"
        public int[][] obtenerAmortizacion(Prestamo prestamo)
        {
            _prestamo = prestamo;
            int plazo = prestamo.Plazo;
            int[][] amortizacion = new int[plazo + 1][];
            float montoRestante = prestamo.Monto;

            for (int i = 0; i <= plazo; i++)
            {
                amortizacion[i] = new int[5];
                amortizacion[i][0] = i; // Periodo

                if (i == 0)
                {
                    amortizacion[i][4] = (int)montoRestante; // Primer periodo, solo se llena el Prestamo
                }
                else
                {
                    int cuota = prestamo.obtenerCuota(); // Cuota
                    float interes = montoRestante * prestamo.Tasainteres; // Interes
                    float interesCompleto = montoRestante * prestamo.Tasainteres; // Interes
                    if (interes - (int)interes < 0.50)
                    {
                        interes = (int)interes;
                    }
                    else
                    {
                         interes = (int)interes + 1;
                    }

                   
                    int amortizacionMensual = cuota - (int)interesCompleto; // Amortizacion

                    montoRestante -= amortizacionMensual; // Actualizar el monto restante

                    amortizacion[i][1] = cuota;
                    amortizacion[i][2] = (int)interes;
                    amortizacion[i][3] = amortizacionMensual;
                    amortizacion[i][4] = (int)montoRestante; // Prestamo
                }
            }

            return amortizacion;
        }
        public string obtenerDatos()
        {
            StringBuilder objSB = new StringBuilder();
            objSB.AppendFormat("Id Amortizacion : {0} \n", _idA);
            objSB.AppendFormat("Prestamo        : {0} \n", _prestamo);
            return objSB.ToString();
        }
        #endregion
    }
}
