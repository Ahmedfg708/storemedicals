using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storemedicals
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         static Mutex m;
         public static string user_Name;

        [STAThread]

       
        static void Main()
        {
            bool first = false;
            m = new Mutex(true,Application.ProductName.ToString(),out first);
            if ((first)) 
              {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new frmMain());
               m.ReleaseMutex();
              } 
             else
             {
                 return;
             }
            
        }
    }
}
