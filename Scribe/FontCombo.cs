using System.Drawing;

namespace System.Windows.Forms
{
    class FontCombo
    {
        // **********************************************************************
        // ************************** Class Variables ***************************
        // **********************************************************************

        // The font style referend
        private Font m_font;

        
        // **********************************************************************
        // **************************** Constructor *****************************
        // **********************************************************************

        /// <name>FontCombo::FontCombo(Font)</name>
        /// <summary>
        /// Initializes the FontCombo class
        /// </summary>
        /// <param name="a_font">The type of font of the text</param>
        /// <author>Michael Marsh</author>
        /// <date>9:50pm 4/17/2016</date>
        public FontCombo(Font a_font)
        {
            //Sets the class variables font to the font passed in the parameter
            m_font = a_font;
        }

        // **********************************************************************
        // ***************************** Properties *****************************
        // **********************************************************************

        /// <name>FindModel::CurrentFont</name>
        /// <summary>
        /// CurrentFont property represents the current font that is being
        /// represented in a ComboBox
        /// </summary>
        /// <value>
        /// The CurrentFont property gets/sets the current Font that connects 
        /// to an option in the ComboBox
        /// </value>
        /// <author>Michel Marsh</author>
        /// <date>10:13pm 4/17/2016</date>
        public Font CurrentFont
        {
            // Returns whether the form should be closed or hidden
            get
            {
                return m_font;
            }

            // Sets whether the form should be closed or hidden
            set
            {
                m_font = value;
            }
        }


        // **********************************************************************
        // *************************** Utility Method ***************************
        // **********************************************************************

        /// <name>FontCombo::ToString</name>
        /// <summary>
        /// Overrides the ToString method To display Current Font's Name
        /// </summary>
        /// <returns>The name of the font as a string</returns>
        /// <author>Michael Marsh</author>
        /// <date>9:55pm 4/17/2016</date>
        public override string ToString()
        {
            return CurrentFont.Name;
        }
    }
}
