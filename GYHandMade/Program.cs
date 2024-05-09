using GYHandMade.Classes.Goals;
using GYProject.Classes;
using GYProject.Classes.userAll;
using System;
using System.Collections.Generic;
using System.IO;
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


            

            /*DateTime date = DateTime.ParseExact("10/10/2026", "MM/dd/yyyy", null);

            Goal goal = new Goal("goal2", "cat2", 2000, date);
            User us = userDB.GetUserById(3016);
            us.AddAmountToGoals(4, 100, "Espece");*/

            //User user = new User("youssef", "youssef", "youssef", "youssef",null);
            //user.AddUser();


            SetProcessDPIAware();
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new Login());

            //HII YOUSSEFFFFF
        }
         [DllImport("user32.dll")]
         private static extern bool SetProcessDPIAware();
    }
}
