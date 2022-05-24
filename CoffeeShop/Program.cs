using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static class Global
        {
            public static bool isAuth = false;
            public static UserEntity user = new UserEntity();
            public static string serverName = "(localdb)\\MSSQLLocalDB";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TablesForm());

            

            Application.Run(new Login());
        }
    }
}
