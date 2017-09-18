using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer.Services;

namespace Clinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Seed s = new Seed();
            s.SeedDatabse();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new Doctor());
            // Application.Run(new Registrar());
            //Application.Run(new RegistrarMainForm("reg"));
            //Application.Run(new Laboratory_MW("LABM", "wazniak"));
            //Application.Run(new Laboratory_MW("LABW", "robol"));
            // Application.Run(new SelectPersonForm("Modify", false));
        }
    }
}
