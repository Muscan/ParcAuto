using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcAuto
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());


            //ControllerMasina cm = new ControllerMasina();
            //Masina m = new Masina("Ticon", 2111, 23232,"Rosie", 2321, "AWD",true);


            ////cm.printAllCars();
            ////cm.Delete("Tico");

            //cm.Add(m);
            //m.toSave();
            //cm.saveToFileTxt();

            //MessageBox.Show(cm.printAllCars());





        }
    }
}
