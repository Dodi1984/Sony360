using Sony360.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sony360
{
    static class Program
    {
        private static ViewController viewController; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>        
        [STAThread]
        static void Main()
        {
            viewController = ViewController.getViewControllerInstance();
        }
    }
}
