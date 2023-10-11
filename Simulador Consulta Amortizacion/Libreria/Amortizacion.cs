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
        public int obtenerAmortizacion()
        {
            try
            {

            }
            catch (Exception)
            {
                return new int[,] {{ -1 }};
            }
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
