using Consulta_Amortizacion_Prestamo.Libreria;

namespace Simulador_Consulta_Amortizacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Monto = 1000000;
            prestamo.Tasainteres = 0.038f;
            prestamo.Plazo = 12;
            mostrarResultado(prestamo);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Consulta_Amortizacion_Prestamo());

            
        }
        public static void mostrarResultado(Prestamo obj1)
        {
            Console.WriteLine(obj1.obtenerDatos());
        }

        public static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }
    }

}