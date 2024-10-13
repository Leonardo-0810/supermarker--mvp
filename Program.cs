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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModelView();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, reposity);
            Application.Run((Form)view);
        }
    }
}
