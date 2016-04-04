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
    public partial class GoToForm : Form
    {
        // **********************************************************************
        // ************************** Class Variables ***************************
        // **********************************************************************

        // Holds the reference to the current document the user is working on
        private ScribeView m_scribeView;

        // **********************************************************************
        // **************************** Constructors ****************************
        // **********************************************************************

        /// <name>GoToForm::GoToForm</name>
        /// <summary>
        /// Default Constructor for the GoTo Form
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>10:00pm 4/3/2016</date>
        public GoToForm()
        {
            // Initialize the GUI for the GoTo Form
            InitializeComponent();
        }

        /// <name>GoToForm::GoToForm(a_scribeView, lineNumber)</name>
        /// <summary>
        /// Constructor for the GoTo Form that requires a reference the current 
        /// document the user is working on
        /// </summary>
        /// <param name="a_scribeView">Reference to the Scribe View</param>
        /// <param name="a_lineNumber">
        /// Reference to the current line the cursor is on in the document
        /// </param>
        /// <author>Michael Marsh</author>
        /// <date>9:45pm 4/3/2016</date>
        public GoToForm(ScribeView a_scribeView, int a_lineNumber)
        {
            // Stores a reference to the document the user connected to this form
            m_scribeView = a_scribeView;

            // Initialize the GUI for the GoTo Form
            InitializeComponent();

            // Store the current line number in the line number text box
            int lineNum = a_lineNumber + 1;
            m_lineNumTxtBox.Text = lineNum.ToString();
        }

        // **********************************************************************
        // ******************** Action Performed - Controller *******************
        // **********************************************************************

        /// <name>GoToForm::GoToBtn_Click</name>
        /// <summary>
        /// Searches for the line specified by the user
        /// </summary>
        /// <param name="a_sender">Refers to the m_goToBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>10:22pm 4/3/2016</date>
        private void GoToBtn_Click(object a_sender, EventArgs a_args)
        {
            // Tries to executes the actions of the Go To Button. If something 
            // goes wrong while setting the cursor position, throw an exception
            try
            {
                // Get the line number from the user inputted that corresponds with
                // the line number in the document
                int lineNum = Int32.Parse(m_lineNumTxtBox.Text) - 1;

                // Gets the index of the first character on the desired line the
                // user wants to set the cursor position in the document
                int cursorPos =
                    m_scribeView.GetDocument().GetFirstCharIndexFromLine(lineNum);

                // Set the cursor to the beginning of that line
                m_scribeView.GetDocument().Select(cursorPos, 0);

                // Set the form to invisible
                this.Hide();
            }

            // Catch the exception and inform the user to enter a valid line number
            catch
            {
                MessageBox.Show("Must input a valid line number",
                    "Invalid Line Number", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
        }

        /// <name>GoToForm::CancelBtn_Click</name>
        /// <summary>
        /// Closes the GoTo Window Form
        /// </summary>
        /// <param name="a_sender">Refers to the m_cancelBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>10:04pm 4/3/2016</date>
        private void CancelBtn_Click(object a_sender, EventArgs a_args)
        {
            // Calls on GoToForm's method of closing a form
            this.Close();
        }
    }
}