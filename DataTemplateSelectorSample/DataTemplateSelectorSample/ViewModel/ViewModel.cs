using System;
using System.Collections.Generic;
using System.Text;

namespace DataTemplateSelectorSample
{
    /// <summary>
    /// ViewModel class
    /// </summary>
    public class ViewModel
    {
        /// <summary>
        /// ViewModel Constructor
        /// </summary>
        public ViewModel()
        {
            ImageCollection.Add(new Model("movie1.png"));
            ImageCollection.Add(new Model("movie2.png"));
            ImageCollection.Add(new Model("movie3.png"));
            ImageCollection.Add(new Model("movie4.png"));
            ImageCollection.Add(new Model("movie5.png"));
            ImageCollection.Add(new Model("movie6.png"));

        }

        /// <summary>
        /// ImageCollection value
        /// </summary>
        private List<Model> imageCollection = new List<Model>();

        /// <summary>
        /// Gets or sets the value for the ImageCollection
        /// </summary>
        public List<Model> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}
