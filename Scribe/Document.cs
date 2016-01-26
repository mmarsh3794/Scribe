using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scribe
{
    public partial class Document : Form
    {
        // Name of the file that stores the document the user is editing
        private string m_fileName;

        /// <name>Document::Document()</name>
        /// <summary>
        /// Default constructor or the Document Class that creates a blank document
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>5:48pm 1/23/2016</date>
        public Document()
        {
            // Initialzes the GUI
            InitializeComponent();

            // Initializes fileName to empty string and indicates to the user that a file name
            // was not specified
            m_fileName = "";
            this.Text = "Untitled - Scribe";
        }

        /// <name>Document::MnuFileNew_Click</name>
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

        // .doc, .docx, .txt, .rtf, .pdf, .odt, .wpd
        private void MnuFileOpen_Click(object a_sender, EventArgs a_args)
        {
            // Creates a dialog box enabling the user to open the document they want to edit
            DialogResult result;

            // Displays the open file dialog to the console
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                // Set filter options and filter index for the file options.
                fileChooser.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                fileChooser.FilterIndex = 1;

                result = fileChooser.ShowDialog();
                m_fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                // If the user specified an invalid file, display an error to the user
                if (m_fileName == string.Empty)
                {
                    MessageBox.Show("Invalid file name. Can not open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadFile();
                }
            }
        }

        /// <name>Document::LoadFile</name>
        /// <summary>
        /// Opens a file, copies all of its contents to the RichTextBox and updates the form
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>2:24pm 1/26/2016</date>
        private void LoadFile()
        {
            // Opens the file to be read
            StreamReader file = new StreamReader(m_fileName);

            // Stores all the contents from the file to the RichTextBox
            m_rtbDoc.Text = file.ReadToEnd();

            // Closes the file and sets the StreamReader to Null
            file.Close();
            file = null;

            // Moves the cursor to the start of the document and initializes the text to entirely unselected
            m_rtbDoc.SelectionStart = 0;
            m_rtbDoc.SelectionLength = 0;

            // Displays the name of the file on the screen
            string displayName = TrimFileName(m_fileName);
            this.Text = displayName += " - Scribe";
        }

        /// <name>Document::TrimFileName</name>
        /// <summary>
        /// Takes a file name and returns a string with all the directors from the file
        /// removed, leaving only the name of the file and its extension
        /// </summary>
        /// <param name="a_fileName">
        /// String containing the name of the file containing an unspecified number of directories
        /// </param>
        /// <returns>String containing only the name of the file and the extension</returns>
        /// <author>Michael Marsh</author>
        /// <date>2:54pm 1/26/2016</date>
        private string TrimFileName(string a_fileName)
        {
            // 
            return a_fileName.Remove(0, a_fileName.LastIndexOf("\\") + 1);
        }
    }
}
