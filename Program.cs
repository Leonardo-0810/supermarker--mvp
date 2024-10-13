using Supermarker_mvp._Repositories;
using Supermarker_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarker_mvp.Models;
using Supermarker_mvp.Properties;
using Supermarker_mvp.Presenters;


namespace Supermarker_mvp
{
    // O referencias
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        // O referencias
        static void Main()
        {
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
