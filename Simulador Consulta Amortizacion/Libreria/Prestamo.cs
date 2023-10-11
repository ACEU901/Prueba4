using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Amortizacion_Prestamo.Libreria
{
    internal class Prestamo : IPrestamo
    {
        #region"Atributos"
        private int _monto;
        private float _tasainteres;
        private int _plazo;
        #endregion
        #region "Constructor"
        public Prestamo()
        {
            _monto = 0;
            _tasainteres = 0.0F;
            _monto = 0;
        }
        public Prestamo(int monto, float tasainteres, int plazo)
        {
            _monto = monto;
            _tasainteres = tasainteres;
            _plazo = plazo;
        }
        #endregion
        #region"Propiedades"
        public int Monto
        {
            set { _monto = value; }
            get { return _monto; }
        }
        public float Tasainteres
        {
            set { _tasainteres = value;}
            get { return _tasainteres; }
        }
        public int Plazo
        {
            set { _plazo = value; }
            get { return _plazo; }
        }
        #endregion
        #region"Metodos"
        public float obtenerInteresAcumulado()
        {
            try
            {
                double tasa = (1 + _tasainteres);
                double plazo = _plazo;
                return (float)Math.Pow(tasa, plazo);
            }
            catch (Exception)
            {
                return -1.0F;
            }
        }
        public int obtenerCuota()
        {
            try
            {
                float ia = obtenerInteresAcumulado();
                return (int)Math.Round(_monto * ((ia * _tasainteres) / (ia - 1)));
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public string obtenerDatos()
        {
            StringBuilder objSB = new StringBuilder();
            objSB.AppendFormat("Monto        : {0} \n", _monto);
            objSB.AppendFormat("Tasa Interes : {0} \n", _tasainteres);
            objSB.AppendFormat("Plazo        : {0} \n", _plazo);
            objSB.AppendFormat(" \n");
            objSB.AppendFormat("Cuota        : {0} \n", obtenerCuota());
            return objSB.ToString();
        }
        #endregion
    }
}
