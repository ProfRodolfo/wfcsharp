using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursowf
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
<<<<<<< HEAD
            Application.Run(new Frm_HelloWorld());
=======
            Application.Run(new HelloWorld());
>>>>>>> 11dd1645ea1719e387b07701a9f4ddc4d61f98e5
        }
    }
}
