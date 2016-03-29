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
    public partial class FindView : Form
    {
        // Referenece to FindView's model
        private FindModel m_findModel;

        // Holds the reference to the current document the user is working on
        private ScribeView m_scribeView;

        /// <name>FindView::FindView(a_scribeView)</name>
        /// <summary>
        /// Constructor for the FindForm that requires a refrence the current document
        /// the user is working on
        /// </summary>
        /// <param name="a_scribeView">Reference to the scribeView</param>
        /// <author>Michael Marsh</author>
        /// <date>3:08pm 3/18/2016</date>
        public FindView(ScribeView a_scribeView)
        {
            // Initializes this form's model
            m_findModel = new FindModel();

            // Set the parameters with the class variable
            m_scribeView = a_scribeView;

            // Initialize the GUI for the find form
            InitializeComponent();
        }

        /// <name>FindView::FindTxtBox_TextChanged</name>
        /// <summary>
        /// Checks to see if there is any text in the text box, in order to
        /// determine whether the Find Next button should be enabled or
        /// disabled
        /// </summary>
        /// <param name="a_sender">
        /// User Input that changed the value of the text property of m_findTxtBox
        /// </param>
        /// <param name="a_args">Data about the change in m_findTextBox</param>
        /// <author>Michael Marsh</author>
        /// <date>3:35pm 3/18/2016</date>
        private void FindTxtBox_TextChanged(object a_sender, EventArgs a_args)
        {
            // If there is any text in the findTextBox, enable the Find Next Button
            if (m_findTxtBox.Text != "")
            {
                m_fndNxtBtn.Enabled = true;
            }

            // Else there is no text in the findTextBox, so disable the Find Next Button
            else
            {
                m_fndNxtBtn.Enabled = false;
            }
        }

        /// <name>FindView::FindForm_FormClosing</name>
        /// <summary>
        /// Handles the operation of closing the form. When m_closeForm is true, then the form
        /// should be closed as normally. When m_closeForm is false, then the form should be hidden
        /// so all the data the user entered can be saved and accesed at a later date
        /// </summary>
        /// <param name="a_sender">Refers to the FindForm</param>
        /// <param name="a_args">Data on the event that caused the form being closed</param>
        /// <author>Michael Marsh</author>
        /// <date>7:48pm 3/28/2016</date>
        private void FindForm_FormClosing(object a_sender, FormClosingEventArgs a_args)
        {
            // If the document linked to this form is not closing, then hide the form to save
            // all of the data long with it
            //if (!m_closeForm)
            if (!m_findModel.CloseForm)
            {
                // Cancels the close form event
                a_args.Cancel = true;

                // Resets the state of the form to the last search that was saved in the model
                m_findTxtBox.Text = m_findModel.SearchText;
                SetMatchCase();
                SetSearchDirection();

                // Hide the form so that the user can resume it at a later date
                this.Hide();
            }
        }

        /// <name>FindView::FndNxtBtn_Click</name>
        /// <summary>
        /// Saves the data the user inputed into the FindForm in the FindModel before using the
        /// information to perform a search
        /// </summary>
        /// <param name="a_sender">Refers to the m_fndNxtBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>4:05pm 3/18/2016</date>
        private void FndNxtBtn_Click(object a_sender, EventArgs a_args)
        {
            // Updates this models SearchText with the current substring the user is searching
            // for in the documetn
            m_findModel.SearchText = m_findTxtBox.Text;

            // If the user enabled case sensitive searching, update the model's MatchCase by
            // setting it to true
            if (m_matchCaseCheckBox.Checked)
            {
                m_findModel.MatchCase = true;
            }

            // Else the user disabled case sensitive searching, so update the model's MatchCase by
            // setting it to false
            else
            {
                m_findModel.MatchCase = false;
            }

            // If the user wants to search down from the cursor point, update the model's SearchDown
            // by setting it to true
            if (m_downRadioBtn.Checked)
            {
                m_findModel.SearchDown = true;
            }

            // Else the user wants to search up from the cursor point, so update the model's SearchDown
            // by setting it to false
            else
            {
                m_findModel.SearchDown = false;
            }

            // Use the information from the form to initiate a search on the document
            SearchRichTextBox();
        }

        /// <name>FindView::CancelBtn_Click</name>
        /// <summary>
        /// Closes the Find Window Form
        /// </summary>
        /// <param name="a_sender">Refers to the m_cancelBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>3:55pm 3/18/2016</date>
        private void CancelBtn_Click(object a_sender, EventArgs a_args)
        {
            // Calls on FindForm's method of closing a form
            this.Close();
        }

        /// <name>FindView::GetFindModel</name>
        /// <summary>
        /// Returns a reference to this class's m_findModel
        /// </summary>
        /// <returns>Reference to this class's m_findModel</returns>
        /// <author>Michel Marsh</author>
        /// <date>8:55pm 3/28/2016</date
        public FindModel GetFindModel()
        {
            return m_findModel;
        }

        /// <name>FindView::CloseForm</name>
        /// <summary>
        /// Returns the string inside the m_findTxtBox
        /// </summary>
        /// <returns> The text inside m_findTxtBox as a String</returns>
        /// <author>Michel Marsh</author>
        /// <date>8:13pm 3/28/2016</date>
        public String GetSearchString()
        {
            return m_findTxtBox.Text;
        }

        /// <name>FindView::SetMatchCase</name>
        /// <summary>
        /// Sets the MatchCase option in this form by using the last saved information from
        /// the form's model
        /// </summary>
        /// <author>Michel Marsh</author>
        /// <date>10:25pm 3/28/2016</date>
        private void SetMatchCase()
        {
            // If MatchCase is true, then check that the user wants to perform a case sensitive search
            if (m_findModel.MatchCase)
            {
                m_matchCaseCheckBox.Checked = true;
            }

            // Slse MatchCase is fasle, so uncheck that the user wants to perform a case-sensitive search
            // in order to perform an non case-sensitive search
            else
            {
                m_matchCaseCheckBox.Checked = false;
            }
        }

        /// <name>FindView::SetSearchDirection</name>
        /// <summary>
        /// Sets the search direction in this form by using the last saved information from
        /// the form's model
        /// </summary>
        /// <author>Michel Marsh</author>
        /// <date>10:45pm 3/28/2016</date>
        private void SetSearchDirection()
        {
            // If the user wants to search down from the cursor
            if (m_findModel.SearchDown)
            {
                // Check of that the user wants to search down and uncheck the search up radio button
                m_downRadioBtn.Checked = true;
                m_upRadioBtn.Checked = false;
            }

            // Else the user wants to seach up from the cursor
            else
            {
                // Check of that the user wants to search up and uncheck the search down radio button
                m_upRadioBtn.Checked = true;
                m_downRadioBtn.Checked = false;
            }
        }

        /// <name>FindForm::SearchRichTextBox</name>
        /// <summary>
        /// Searches the currrent document for the incidated word.
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>7:59pm 3/21/2016</date>
        public void SearchRichTextBox()
        {
            // Variable to hold the current cursor postion
            int cursorPos = -1;
            
            // If there is any text that is highlighted and you are not doing a reverse search, 
            // set the cursor posion to the end of the higlighed text
            if (!m_upRadioBtn.Checked && m_scribeView.GetDocument().SelectionLength > 0)
            {
                cursorPos = m_scribeView.GetDocument().SelectionStart + m_scribeView.GetDocument().SelectionLength;
            }

            // Else there is no highlighted text so set it to the start of the text
            else
            {
                cursorPos = m_scribeView.GetDocument().SelectionStart;
            }
            
            // Indicates that the user wants to do a reverse search
            if (m_upRadioBtn.Checked)
            {
                // If the cursor is at the begining of the document in a reverse search, indicate that
                // no results to prevent searching the entire document
                if (cursorPos == 0)
                {
                    cursorPos = -1;
                }

                // Performs a reverse case sensitive search
                else if (m_matchCaseCheckBox.Checked)
                {
                    // Finds the location of the first character of the search string in the document
                    // and stores it in cursorPos. Returns -1 if the search is empty.
                    cursorPos = m_scribeView.GetDocument().Find(m_findTxtBox.Text, 0,
                        cursorPos, RichTextBoxFinds.MatchCase | RichTextBoxFinds.Reverse);
                }

                // Performs a reverse non-case sensitive search
                else
                {
                    // Finds the location of the first character of the search string in the document
                    // and stores it in cursorPos. Returns -1 if the search is empty.
                    cursorPos = m_scribeView.GetDocument().Find(m_findTxtBox.Text, 0,
                        cursorPos, RichTextBoxFinds.Reverse);
                }
            }

            // Indicates that the user wants to do a regular search
            else
            {
                // If the cursor is at the end of the document in a normal search, indicate that
                // no results to prevent searching the entire document
                if (cursorPos == m_scribeView.GetDocument().Text.Length)
                {
                    cursorPos = -1;
                }

                // Performs a normal case sensitive search
                else if (m_matchCaseCheckBox.Checked)
                {
                    // Finds the location of the first character of the search string in the document
                    // and stores it in cursorPos. Returns -1 if the search is empty.
                    cursorPos = m_scribeView.GetDocument().Find(m_findTxtBox.Text, cursorPos,
                        m_scribeView.GetDocument().Text.Length, RichTextBoxFinds.MatchCase);
                }

                // Performs a normal non-case sensitive search
                else
                {
                    // Finds the location of the first character of the search string in the document
                    // and stores it in cursorPos. Returns -1 if the search is empty.
                    cursorPos = m_scribeView.GetDocument().Find(m_findTxtBox.Text, cursorPos,
                        m_scribeView.GetDocument().Text.Length, RichTextBoxFinds.None);
                }
            }           

            // If the search string isn't in the document, report that the word is not in the document
            // and exit the function
            if (cursorPos == -1)
            {
                MessageBox.Show("Cannot find \"" + m_findTxtBox.Text.ToString() + "\"",
                    "No Matches", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
        }
    }
}
