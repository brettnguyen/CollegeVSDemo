using System;
using CollegeVS.Models;
using Xamarin.Forms;

namespace CollegeVS.Controls
{
    public class CreateSentIncomingDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CreateTemp { get; set; }
        public DataTemplate SentDareTemp { get; set; }
        public DataTemplate IncomingTemp { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            

            if (((CreateSentIncomingModel)item).Nothing == "Nothing")

                return ((CreateSentIncomingModel)item).Nothing.Contains("Nothing") ? CreateTemp : SentDareTemp;
            else
                return ((CreateSentIncomingModel)item).Nothing.Contains("Empty") ? SentDareTemp : IncomingTemp;





        }
    }
}
