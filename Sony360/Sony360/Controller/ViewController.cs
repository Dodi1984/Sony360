using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sony360.Controller
{

        ///  <summary>
        /// Singleton class for views controlling
        ///</summary>
        ///
    class ViewController
    {
        private static ViewController viewController;
        ///<summary>
        ///private constructot
        ///</summary>
        private ViewController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        ///<summary>
        ///Get ViewController instance
        ///</summary>        
        public static ViewController getViewControllerInstance()
        {
            if (viewController==null)
            {
                viewController = new ViewController();
            }
            return viewController;
        }


    }
}
