//using SoCar.Winform.BaseForms;
using SoCar.Data;
using SoCar.Winform.Forms;
using SoCar.Winform.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoCar.Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new InsertRentForm());
            //LoginProxy.Login = DataRepository.Login.GetByPK(1);
            //LoginProxy.Login = DataRepository.Login.Get("abc123", "abc123");
            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
            //hi

        }
    }
}
