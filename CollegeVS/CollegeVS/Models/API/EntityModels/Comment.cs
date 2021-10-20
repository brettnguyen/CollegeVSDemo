using System;
using System.Collections.Generic;

namespace CollegeVS.Models.API.EntityModels
{
    public partial class Comment
    {
        public int Comment_ID { get; set; }
        public int User_ID { get; set; }
        public int Video_ID { get; set; }
        public string Content { get; set; }
        public System.DateTime Date { get; set; }
    }
}
