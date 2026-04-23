using LABA7_OOP.Controller;
using LABA7_OOP.Model;
using LABA7_OOP.View;
using System.Runtime.InteropServices;

namespace LABA7_OOP
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].ToLower() == "console")
            {
                AllocConsole();
                var model = new ShopModel();
                var view = new ConsoleView();
                var controller = new ShopController(model, view);
                view.Run();
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}