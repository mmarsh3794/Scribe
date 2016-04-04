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
    public partial class ReplaceView : Form
    {
        // **********************************************************************
        // ************************** Class Variables ***************************
        // **********************************************************************

        // Reference to ReplaceView's model
        private ReplaceModel m_replaceModel;

        // Holds the reference to the current document the user is working on
        private ScribeView m_scribeView;

        // **********************************************************************
        // **************************** Constructor *****************************
        // **********************************************************************

        /// <name>ReplaceView::ReplaceView(a_scribeView)</name>
        /// <summary>
        /// Constructor for the ReplaceForm that requires a reference the current 
        /// document the user is working on
        /// </summary>
        /// <param name="a_scribeView">Reference to the Scribe View</param>
        /// <author>Michael Marsh</author>
        /// <date>7:35pm 4/3/2016</date>
        public ReplaceView(ScribeView a_scribeView)
        {
            // Initializes this form's model
            m_replaceModel = new ReplaceModel();

            // Set the parameters with the class variable
            m_scribeView = a_scribeView;

            // Initialize the GUI for the replace form
            InitializeComponent();
        }

        // **********************************************************************
        // **************************** GUI Components **************************
        // **********************************************************************

        /// <name>ReplaceView::FindTxtBox_TextChanged</name>
        /// <summary>
        /// Checks to see if there is any text in the text box, in order to
        /// determine whether the Find Next button should be enabled or
        /// disabled
        /// </summary>
        /// <param name="a_sender">
        /// User Input that changed the value of the text property of m_findTxtBox
        /// </param>
        /// <param name="a_args">Data about the change in m_findTxtBox</param>
        /// <author>Michael Marsh</author>
        /// <date>7:40pm 4/3/2016</date>
        private void FindTxtBox_TextChanged(object a_sender, EventArgs a_args)
        {
            // If there is any text in the findTxtBox, enable the Find Next Button
            if (m_findTxtBox.Text != "")
            {
                m_findBtn.Enabled = true;
            }

            // Else there is no text in the findTxtBox, so disable the Find 
            // Next Button
            else
            {
                m_findBtn.Enabled = false;
            }
        }

        /// <name>ReplaceView::ReplaceTxtBox_TextChanged</name>
        /// <summary>
        /// Checks to see if there is any text in the text box, in order to
        /// determine whether the Replace and the Replace All buttons should be 
        /// enabled or disabled
        /// </summary>
        /// <param name="a_sender">
        /// User Input that changed the value of the text property of 
        /// m_replaceTxtBox
        /// </param>
        /// <param name="a_args">Data about the change in m_replaceTextBox</param>
        /// <author>Michael Marsh</author>
        /// <date>7:45pm 4/3/2016</date>
        private void ReplaceTxtBox_TextChanged(object a_sender, EventArgs a_args)
        {
            // If there is any text in the replaceTxtBox, enable the Replace
            // and Replace All Buttons
            if (m_replaceTxtBox.Text != "")
            {
                m_replaceBtn.Enabled = true;
                m_replaceAllBtn.Enabled = true;
            }

            // Else there is no text in the replaceTextBox, so disable the Replace
            // and Replace All Buttons
            else
            {
                m_replaceBtn.Enabled = false;
                m_replaceAllBtn.Enabled = false;
            }
        }

        /// <name>ReplaceView::ReplaceView_FormClosing</name>
        /// <summary>
        /// Handles the operation of closing the form. When CloseForm is true, 
        /// then the form should be closed as normally. When CloseForm is false, 
        /// then the form should be hidden so all the data the user entered can 
        /// be saved and accessed at a later date
        /// </summary>
        /// <param name="a_sender">Refers to the FindForm</param>
        /// <param name="a_args">
        /// Data on the event that caused the form being closed
        /// </param>
        /// <author>Michael Marsh</author>
        /// <date>7:48pm 3/28/2016</date>
        private void ReplaceView_FormClosing(object a_sender,
            FormClosingEventArgs a_args)
        {
            // If the document linked to this form is not closing, then hide the 
            // form to save all of the data long with it
            if (!m_replaceModel.CloseForm)
            {
                // Cancels the close form event
                a_args.Cancel = true;

                // Resets the state of the form to the last search that was saved 
                // in the model
                m_findTxtBox.Text = m_replaceModel.SearchText;
                m_replaceTxtBox.Text = m_replaceModel.ReplaceText;
                SetMatchCase();

                // Hide the form so that the user can resume it at a later date
                this.Hide();
            }
        }

        // **********************************************************************
        // ******************** Action Performed - Controller *******************
        // **********************************************************************

        /// <name>ReplaceView::FindBtn_Click</name>
        /// <summary>
        /// Saves the data the user inputted into the ReplaceForm in the 
        /// ReplaceModel before using the information to perform a search
        /// </summary>
        /// <param name="a_sender">Refers to the m_findBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>8:27pm 4/3/2016</date>
        private void FindBtn_Click(object a_sender, EventArgs a_args)
        {
            // Transfers all of the data from ReplaceView and stores it in it's 
            // model
            SaveData();

            // Use the information from the form to initiate a search on the 
            // document
            SearchRichTextBox();
        }

        /// <name>ReplaceView::ReplaceBtn_Click</name>
        /// <summary>
        /// Saves the data the user inputted into the ReplaceForm in the 
        /// ReplaceModel before either replacing the selected substring if it 
        /// matches the substring the user wants to replace with the desired 
        /// substring or finds the next instance of the substring the user wants 
        /// to replace
        /// </summary>
        /// <param name="a_sender">Refers to the m_replaceBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>9:06pm 4/3/2016</date>
        private void ReplaceBtn_Click(object a_sender, EventArgs a_args)
        {
            // Transfers all of the data from ReplaceView and stores it in it's 
            // model
            SaveData();

            // If there is any text that is selected in the document and it 
            // matches the substring we want to replace, then replace it with the 
            // selected text
            if (m_scribeView.GetDocument().SelectionLength != 0 &&
                m_scribeView.GetDocument().SelectedText.Equals(m_findTxtBox.Text))
            {
                m_scribeView.GetDocument().SelectedText = m_replaceTxtBox.Text;
            }

            // Finds the next occurance of the text the user wants to replace
            SearchRichTextBox();
        }

        /// <name>ReplaceView::ReplaceAllBtn_Click</name>
        /// <summary>
        /// Saves the data the user inputted into the ReplaceForm in the 
        /// ReplaceModel before replacing all instances of the desired substring 
        /// with the substring the user wants to replace it with
        /// </summary>
        /// <param name="a_sender">Refers to the m_replaceAllBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>9:18pm 4/3/2016</date>
        private void ReplaceAllBtn_Click(object a_sender, EventArgs a_args)
        {
            // Transfers all of the data from ReplaceView and stores it in it's 
            // model
            SaveData();

            // Replaces all instances of the substring the user wants to 
            // replace, with the substring the user wants to replace it and set 
            // the changes as the new document
            m_scribeView.GetDocument().Text =
                m_scribeView.GetDocument().Text.Replace(m_findTxtBox.Text,
                m_replaceTxtBox.Text);

            // Move the cursor back to the beginning of the file
            m_scribeView.GetDocument().SelectionStart = 0;
        }

        /// <name>ReplaceView::CancelBtn_Click</name>
        /// <summary>
        /// Closes the Replace Window Form
        /// </summary>
        /// <param name="a_sender">Refers to the m_cancelBtn</param>
        /// <param name="a_args">Contains data from the button click</param>
        /// <author>Michael Marsh</author>
        /// <date>7:57pm 4/3/2016</date>
        private void CancelBtn_Click(object a_sender, EventArgs a_args)
        {
            // Calls on ReplaceView's method of closing a form
            this.Close();
        }

        // **********************************************************************
        // **************************** Selectors *******************************
        // **********************************************************************

        /// <name>ReplaceView::GetReplaceModel</name>
        /// <summary>
        /// Returns a reference to this class's m_replaceModel
        /// </summary>
        /// <returns>Reference to this class's m_replaceModel</returns>
        /// <author>Michel Marsh</author>
        /// <date>8:00pm 4/03/2016</date
        public ReplaceModel GetReplaceModel()
        {
            return m_replaceModel;
        }

        // **********************************************************************
        // ***************************** Mutators *******************************
        // **********************************************************************

        /// <name>ReplaceView::SetMatchCase</name>
        /// <summary>
        /// Sets the MatchCase option in this form by using the last saved 
        /// information from the form's model
        /// </summary>
        /// <author>Michel Marsh</author>
        /// <date>7:48pm 4/3/2016</date>
        private void SetMatchCase()
        {
            // If MatchCase is true, then check that the user wants to perform a 
            // case sensitive search
            if (m_replaceModel.MatchCase)
            {
                m_matchCaseCheckBox.Checked = true;
            }

            // Else MatchCase is false, so uncheck that the user wants to perform 
            // a case-sensitive search in order to perform an non case-sensitive 
            // search
            else
            {
                m_matchCaseCheckBox.Checked = false;
            }
        }

        // **********************************************************************
        // *************************** Utility Methods **************************
        // **********************************************************************

        /// <name>ReplaceView::SaveData</name>
        /// <summary>
        /// Transfers all of the current information that the user inputted into 
        /// the ReplaceView is saved in its model
        /// </summary>
        /// <author>Michel Marsh</author>
        /// <date>8:59pm 4/3/2016</date>
        private void SaveData()
        {
            // Updates this model's SearchText and ReplaceText with the current 
            // substrings the user is searching for in the document
            m_replaceModel.SearchText = m_findTxtBox.Text;
            m_replaceModel.ReplaceText = m_replaceTxtBox.Text;

            // If the user enabled case sensitive searching, update the model's 
            // MatchCase by setting it to true
            if (m_matchCaseCheckBox.Checked)
            {
                m_replaceModel.MatchCase = true;

            }

            // Else the user disabled case sensitive searching, so update the 
            // model's MatchCase by setting it to false
            else
            {
                m_replaceModel.MatchCase = false;
            }
        }

        /// <name>ReplaceView::SearchRichTextBox</name>
        /// <summary>
        /// Searches the current document for the indicated word.
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>8:50pm 4/3/2016</date>
        private void SearchRichTextBox()
        {
            // Variable to hold the current cursor position
            int cursorPos = -1;

            // If there is any text that is highlighted, set the cursor position to 
            // the end of the highlighted text
            if (m_scribeView.GetDocument().SelectionLength > 0)
            {
                cursorPos = m_scribeView.GetDocument().SelectionStart
                    + m_scribeView.GetDocument().SelectionLength;
            }

            // Else there is no highlighted text so set it to the start of the text
            else
            {
                cursorPos = m_scribeView.GetDocument().SelectionStart;
            }

            // If the cursor is at the end of the document indicate that no results 
            // to prevent searching the entire document
            if (cursorPos == m_scribeView.GetDocument().Text.Length)
            {
                cursorPos = -1;
            }

            // If the user enabled case sensitive searching
            else if (m_matchCaseCheckBox.Checked)
            {
                // Finds the location of the first character of the search string 
                // in the document and stores it in cursorPos. Returns -1 if the 
                // search is empty.
                cursorPos = m_scribeView.GetDocument().Find(m_findTxtBox.Text,
                    cursorPos, m_scribeView.GetDocument().Text.Length,
                    RichTextBoxFinds.MatchCase);
            }

            // Else the user disabled case sensitive searching
            else
            {
                // Finds the location of the first character of the search string 
                // in the document and stores it in cursorPos. Returns -1 if the 
                // search is empty.
                cursorPos = m_scribeView.GetDocument().Find(m_findTxtBox.Text,
                    cursorPos, m_scribeView.GetDocument().Text.Length,
                    RichTextBoxFinds.None);
            }

            // If the search string isn't in the document, report that the word is
            // not in the document and exit the function
            if (cursorPos == -1)
            {
                MessageBox.Show("Cannot find \"" + m_findTxtBox.Text.ToString()
                    + "\"", "No Matches", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
        }
    }
}