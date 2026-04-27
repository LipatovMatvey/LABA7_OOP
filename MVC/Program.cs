using MVC.Controller;
using MVC.Model;
using MVC.View;
using System.Runtime.InteropServices;

namespace MVC
{
    internal static class Program
    {
        /// <summary>
        /// Импорт функции AllocConsole для выделения консоли в GUI-приложении.
        /// </summary>
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].ToLower() == "console")
            {
                AllocConsole();
                var collection = new InternetShopCollection();
                var view = new ConsoleView();
                var controller = new ConsoleController(collection, view);
                controller.Run();
            }
            else
            {
                ApplicationConfiguration.Initialize();
                var collection = new InternetShopCollection();
                var form = new Form1(collection);    
                Application.Run(form);
            }
        }
    }
}