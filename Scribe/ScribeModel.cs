using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribe
{
    class ScribeModel
    {
        // Name of the file that stores the document the user is editing
        private string m_fileName;

        // Used to determine if an additional page exists when the document is sent to the printer
        private int m_checkPrint;

        ///<name>ScribeModel::ScribeModel()</name>
        /// <summary>
        /// Creates an instance of ScribeModel where the user started a new document
        /// </summary>
        /// <author>Michael Marsh</author>
        /// <date>4:26pm 1/26/2016</date>
        public ScribeModel()
        {
            // Sets the file name to an empty string
            m_fileName = "";
        }

        /// <name>ScribeModel::ScribeModel(a_fileName)</name>
        /// <summary>
        /// Creates an instance of ScribeModel where the user loaded in a document
        /// </summary>
        /// <param name="a_fileName"> String holding the name of the file the user is editing</param>
        /// <author>Michael Marsh</author>
        /// <date>4:24pm 1/26/2016</date>
        public ScribeModel(string a_fileName)
        {
            // Sets the file name to the file name passed to this function
            m_fileName = a_fileName;
        }


        /// <name>ScribeModel::FileName</name>
        /// <summary>
        /// FileName property represents the name of the file the user is currently editing
        /// </summary>
        /// <value>The FileName property gets/sets the value of the string m_fileName</value>
        /// <author>Michel Marsh</author>
        /// <date>4:45pm 1/26/2016</date>
        public string FileName
        {
            // Returns the name of the file the user is currently editing
            get
            {
                return m_fileName;
            }

            // Sets the name of the file the user is editing to the parameter passed to it
            set
            {
                m_fileName = value;
            }
        }

        /// <name>ScribeModel::CheckPrint</name>
        /// <summary>
        /// CheckPrint property represents whether any more pages need to be printed
        /// </summary>
        /// <value>The CheckPrint property gets/sets the value of the string m_checkPrint</value>
        /// <author>Michel Marsh</author>
        /// <date>9:49pm 2/15/2016</date>
        public int CheckPrint
        {
            // Returns the last character that was printed
            get
            {
                return m_checkPrint;
            }

            // Sets the value of m_checkPrint to the last character that was printed
            set
            {
                m_checkPrint = value;
            }
        }

        /// <name>ScribeModel::GetFileExtension</name>
        /// <summary>
        /// Returns the file extension of the file the user is currently editing
        /// </summary>
        /// <returns>String holding the file extension</returns>
        /// <author>Michael Marsh</author>
        /// <date>6:18pm 1/26/2016</date>
        public string GetFileExtension()
        {
            return m_fileName.Remove(0, m_fileName.LastIndexOf("."));
        }

        /// <name>ScribeModel::TrimFileName</name>
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
        public string TrimFileName(string a_fileName)
        {
            // Takes the last index of \\, everything before that being directories, and uses
            // it to return the file name with all the directories from it
            return a_fileName.Remove(0, a_fileName.LastIndexOf("\\") + 1);
        }
    }
}
