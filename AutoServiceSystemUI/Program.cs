﻿using AutoServiceSystemLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceSystemUI
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

            // Initialize the database connections
            AutoServiceSystemLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new CreateServiceForm());
        }
    }
}
