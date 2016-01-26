using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scribe
{
    static class ScribeDriver
    {
        /// <name>Main</name>
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>5:48pm 1/23/2016</date>
        [STAThread]
        static void Main()
        {
            // Sets up the default frame of the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creates a new fourm, sets up a closed form listener, and displays it to the console.
            var main = new Document();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();

            // Launches the application
            Application.Run();
        }

        ///<name>FormClosed</name>
        /// <summary>
        /// Called when the first form in Applications OpenForm data structure is closed.
        /// If there are any windows left open a new FormClosedEventHandler is created to
        /// the new first of OpenForms, however if there are no more open forms, the
        /// application terminates.
        /// </summary>
        /// <param name="a_sender">Refers to the form that was closed</param>
        /// <param name="a_args">Contains data from the form closing</param>
        /// <author>Michael Marsh</author>
        /// <date>9:50pm 1/24/2016</date>
        static void FormClosed(object a_sender, FormClosedEventArgs a_args)
        {
            // Removes the closed form listener from the form that was closed
            ((Form)a_sender).FormClosed -= FormClosed;

            // If there are no more open forms, close the application
            if (Application.OpenForms.Count == 0) 
                Application.ExitThread();

            // Else set up a new closed form listener to the first of OpenForms
            else 
                Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
