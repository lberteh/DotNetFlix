using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetFlix.Models;
using System.ComponentModel;

namespace DotNetFlix
{
    public static class Program
    {

        public static BindingList<Movy> moviesBindingList;
        public static string totalCost;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            moviesBindingList = new BindingList<Movy>();         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
