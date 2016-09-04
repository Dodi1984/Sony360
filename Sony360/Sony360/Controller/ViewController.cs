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
        private Form1 form1;
        private static ViewController viewController;
        ///<summary>
        ///private constructot
        ///</summary>
        private ViewController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1(this);
            Application.Run(form1);
        }

        public void take_a_360_picture_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        public static ViewController getViewControllerRef()
        {
            if (viewController==null)
            {
                viewController = new ViewController();
            }

            return viewController;
        }
    }
}
