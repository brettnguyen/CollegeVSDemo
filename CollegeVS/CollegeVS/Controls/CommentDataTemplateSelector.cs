using System;
using CollegeVS.Models;
using Xamarin.Forms;

namespace CollegeVS.Controls
{
    public class CommentDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Comment { get; set; }
        public DataTemplate OtherUserComment { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            return ((CommentsSelectorModel)item).Nothing.Contains("Nothing") ? Comment : OtherUserComment;

        }
    }
}
