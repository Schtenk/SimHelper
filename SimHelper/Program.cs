using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public const string ApplicationName = "SimHelper";
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(false, ApplicationName);
            try
            {
                if(mutex.WaitOne(0,false))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show($"Seems another instance of {ApplicationName} is already running.");
                }
            }
            finally
            {
                if(mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }
            
        }
    }
}
