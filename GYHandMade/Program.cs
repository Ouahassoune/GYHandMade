﻿using GYProject.Classes.userAll;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYHandMade
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestDatabaseConnection();
        }

        static void TestDatabaseConnection()
        {
            
        
      SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        
            
        }
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
