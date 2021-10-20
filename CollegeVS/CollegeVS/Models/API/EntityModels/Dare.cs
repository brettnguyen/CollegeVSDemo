using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class Dare
    {
        public int DareId { get; set; }
        public int TxUserID { get; set; }
        public int RxUserID { get; set; }
        public int ReportFlag { get; set; }
        public int State { get; set; }
        public string TextContext { get; set; }
        public Nullable<int> ContentContextID { get; set; }
        public string Category { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateAccepted { get; set; }
        public Nullable<System.DateTime> DateAttempted { get; set; }
        public Nullable<System.DateTime> DateEnded { get; set; }
        public string Title { get; set; }
        public bool TimeExpired { get; set; }
        public Nullable<int> ResponseContentID { get; set; }
        public int PreviousTransition { get; set; }
    }
}
