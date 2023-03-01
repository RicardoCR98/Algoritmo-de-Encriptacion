using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Proyecto2EDA_AlgoritmoEncriptacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Llama al método AllocConsole() para mostrar la consola en tiempo de ejecución
            AllocConsole();

            Application.Run(new Form1());

        }
    }
}