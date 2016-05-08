using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe
{
    public class FindModel
    {
        // **********************************************************************
        // ************************** Class Variables ***************************
        // **********************************************************************

        // Holds whether or not the window should be closed or hidden. Note the 
        // form should only be closed when the main document is being closed
        private Boolean m_closeForm;

        // Holds the current saved string the user is searching for
        private String m_searchText;

        // Holds whether mach case searching is enabled or disabled
        private Boolean m_matchCase;

        // Holds whether the user will be searching down or up
        private Boolean m_searchDown;

        // **********************************************************************
        // **************************** Constructor *****************************
        // **********************************************************************

        /// <name>FindModel::FindModel</name>
        /// <summary>
        /// Default constructor for the FindModel Class that holds all of the 
        /// information needed for the FindView Class
        /// </summary>
        /// <author>Michel Marsh</author>
        /// <date>7:40pm 3/28/2016</date>
        public FindModel()
        {
            // Set the initial class parameter to false, since we want the form 
            // to be hidden until the main document is closed
            m_closeForm = false;
  

            // Initialize the default state of the program which is that a blank 
            // search string where the user wants a non-case sensitive search down 
            // the document
            m_searchText = "";
            m_matchCase = false;
            m_searchDown = true;
        }

        // **********************************************************************
        // ***************************** Properties *****************************
        // **********************************************************************

        /// <name>FindModel::CloseForm</name>
        /// <summary>
        /// CloseForm property represents whether the form should be closed or 
        /// hidden when the FormClosing event is prompted 
        /// </summary>
        /// <value>
        /// The CloseForm property gets/sets the whether the form should be 
        /// closed or hidden
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>7:44pm 3/28/2016</date>
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

        /// <name>FindModel::SearchText</name>
        /// <summary>
        /// SearchText property represents the saved text that the user is 
        /// searching for in the document they are currently editing
        /// </summary>
        /// <value>
        /// The SearchText property gets/sets the saved substring the user is 
        /// searching in the text
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>10:15pm 3/28/2016</date>
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

        /// <name>FindModel::MatchCase</name>
        /// <summary>
        /// MatchCase property represents whether the user wants to enable/disable
        /// case sensitive searching
        /// </summary>
        /// <value>
        /// The MatchCase property gets/sets the whether to enable or 
        /// disable case sensitive searching
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>10:17pm 3/28/2016</date>
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

        /// <name>FindModel::SearchDown</name>
        /// <summary>
        /// SearchDown property represents whether the user wants to search down 
        /// or up from the current cursor position
        /// </summary>
        /// <value>
        /// The SearchDown property gets/sets the whether to search down or 
        /// up from the current cursor position
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>10:19pm 3/28/2016</date>
        public Boolean SearchDown
        {
            // Gets whether the user wants to search down or up from the 
            // current cursor position
            get
            {
                return m_searchDown;
            }

            // Sets whether the user wants to search down or up from the 
            // current cursor position
            set
            {
                m_searchDown = value;
            }
        }
    }
}