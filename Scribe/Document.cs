using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scribe
{
    public partial class Document : Form
    {
        /// <name>Document</name>
        /// <summary>
        /// Iniitalizes a new blank document
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>5:48pm 1/23/2016</date>
        public Document()
        {
            InitializeComponent();
        }

        /// <name>MnuFileNew_Click</name>
        /// <summary>
        /// Creates a new blank document in a new form
        /// </summary>
        /// <param name="a_sender">Refers to the m_mnuFileNew ToolStripMenuItem</param>
        /// <param name="a_args">Does not contain any data from menu click</param>
        /// <author>Michael Marsh</author>
        /// <date>8:54pm 1/24/2016</date>
        private void MnuFileNew_Click(object a_sender, EventArgs a_args)
        {
            // Creates and displays a new blank document
            new Document().Show();
        }
    }
}
