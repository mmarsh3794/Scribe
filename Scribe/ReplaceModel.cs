using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe
{
    public class ReplaceModel
    {
        // **********************************************************************
        // ************************** Class Variables ***************************
        // **********************************************************************

        // Holds whether or not the window should be closed or hidden. Note the 
        // form should only be closed when the main document is being closed
        private Boolean m_closeForm;

        // Holds the current saved string the user is searching for
        private String m_searchText;

        // Holds the current saved string the user is replacing the search 
        // text with
        private String m_replaceText;

        // Holds whether mach case searching is enabled or disabled
        private Boolean m_matchCase;

        // **********************************************************************
        // **************************** Constructor *****************************
        // **********************************************************************

        /// <name>ReplaceModel::ReplaceModel</name>
        /// <summary>
        /// Default constructor for the ReplaceModel Class that holds all of 
        /// the information needed for the ReplaceView Class
        /// </summary>
        /// <author>Michel Marsh</author>
        /// <date>7:22pm 4/03/2016</date>
        public ReplaceModel()
        {
            // Set the initial class parameter to false, since we want the form 
            // to be hidden until the main document is closed
            m_closeForm = false;

            // Initialize the default state of the form which is that a blank 
            // search string where the user wants a non-case sensitive search 
            // down the document
            m_searchText = "";
            m_replaceText = "";
            m_matchCase = false;
        }

        // **********************************************************************
        // ***************************** Properties *****************************
        // **********************************************************************

        /// <name>ReplaceModel::CloseForm</name>
        /// <summary>
        /// CloseForm property represents whether the form should be closed or 
        /// hidden when the FormClosing event is prompted 
        /// </summary>
        /// <value>
        /// The CloseForm property gets/sets the whether the form should 
        /// be closed or hidden
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>7:24pm 4/03/2016</date>
        public Boolean CloseForm
        {
            // Returns whether the form should be closed or hidden
            get
            {
                return m_closeForm;
            }

            // Sets whether the form should be closed or hidden
            set
            {
                m_closeForm = value;
            }
        }

        /// <name>ReplaceModel::SearchText</name>
        /// <summary>
        /// SearchText property represents the saved text that the user is 
        /// searching for in the document they are currently editing
        /// </summary>
        /// <value>
        /// The SearchText property gets/sets the saved substring the user 
        /// is searching in the text
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>7:26pm 4/03/2016</date>
        public String SearchText
        {
            // Returns the saved substring the user is searching for in the 
            // document
            get
            {
                return m_searchText;
            }

            // Sets the saved substring the user is searching for in the document
            set
            {
                m_searchText = value;
            }
        }

        /// <name>ReplaceModel::ReplaceText</name>
        /// <summary>
        /// ReplaceText property represents the saved text that wants to replace 
        /// the search text with in the document they are currently editing
        /// </summary>
        /// <value>
        /// The ReplaceText property gets/sets the saved substring the user 
        /// wants to replace the search text with
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>7:30pm 4/03/2016</date>
        public String ReplaceText
        {
            // Returns the saved substring the user wants to replace the search 
            // text with
            get
            {
                return m_replaceText;
            }

            // Sets the saved substring the user wants to replace the search 
            // text with
            set
            {
                m_replaceText = value;
            }
        }

        /// <name>ReplaceModel::MatchCase</name>
        /// <summary>
        /// MatchCase property represents whether the user wants to 
        /// enable/disable case sensitive searching
        /// </summary>
        /// <value>
        /// The MatchCase property gets/sets the whether to enable or 
        /// disable case sensitive searching
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>7:28pm 4/03/2016</date>
        public Boolean MatchCase
        {
            // Gets whether to enable/disable case sensitive searching
            get
            {
                return m_matchCase;
            }

            // Sets whether to enable/disable case sensitive searching
            set
            {
                m_matchCase = value;
            }
        }
    }
}