using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataTemplateSelectorSample
{
    // Check the conditon and based on the condtion it set the value.
   public class DataTemplateViewModel : DataTemplateSelector
    {
        /// <summary>
        /// default template value.
        /// </summary>
        private DataTemplate defaulttemplate;

        /// <summary>
        /// Get or sets the value of Default template
        /// </summary>
        public DataTemplate DefaultTemplate
        {
            get { return defaulttemplate; }
            set { defaulttemplate = value; }
        }

        /// <summary>
        /// specific template value.
        /// </summary>
        private DataTemplate specifictemplate;

        /// <summary>
        /// Gets or sets the value for the Specific template.
        /// </summary>
        public DataTemplate SpecificTemplate
        {
            get { return specifictemplate; }
            set { specifictemplate = value; }
        }

        /// <summary>
        /// On SelectTempalte method which used to return the particular object.
        /// </summary>
        /// <param name="item">Item value</param>
        /// <param name="container">Contantiner value</param>
        /// <returns>return datatemplate</returns>
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as Model;
            if (message == null)
                return null;
            return message.Image == "movie3.png" ? SpecificTemplate:DefaultTemplate;
        }
    }
}
