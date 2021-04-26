using System;
using System.Collections.Generic;
using System.Text;

namespace DataTemplateSelectorSample
{

    /// <summary>
    /// Model class.
    /// </summary>
   public class Model
    {
        /// <summary>
        /// Model class constructor
        /// </summary>
        /// <param name="imageString">Imge string value</param>
        public Model(string imageString)
        {
            Image = imageString;
        }

        /// <summary>
        /// Image value
        /// </summary>
        private String _image;

        /// <summary>
        /// Gets or sets the value for the Image property.
        /// </summary>
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }

    }
}
