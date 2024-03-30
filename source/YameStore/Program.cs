using YameStore.Screen.Initial;
using YameStore.Screen.Lookups;
using YameStore.Screen.Members;
using YameStore.Screen.POS;

namespace YameStore
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
            Application.Run(new ExchangesForm());
        }
    }
}