using System;
using CollegeVS.Models.API.EntityModels;

namespace CollegeVS.Models.API.HelperClasses
{
    public class DareWrapper
    {
        /// <summary>
        /// The database dare object
        /// </summary>
        public Dare Dare { get; set; }

        /// <summary>
        /// The absolute path to the category image of the Dare
        /// </summary>
        public string CategoryImgAbsPAth { get; set; }

        //<summary>
        //The user sending the dare
        //</summary>
        public User TxUser { get; set; }
        //<summary>
        //The user receiving the dare
        //</summary>
        public User RxUser { get; set; }

        //<summary>
        //The dare ID
        //</summary>
        public int DareID { get; set; }
        //<summary>
        //The dare title
        //</summary>
        public string Title { get; set; }
        //<summary>
        //The ID of the context
        //</summary>
        public int ContentContextID { get; set; }
        //<summary>
        //Response to the dare
        //</summary>
        public Video DareResponse { get; set; }
        //<summary>
        //Context of the dare
        //</summary>
        public Video Context { get; set; }
        //<summary>
        //Details describing the dare
        //</summary>
        public string TextContext { get; set; }
        //<summary>
        //The absolute path to the users
        //</summary>
        public string ContentAbsPath { get; set; }
    }
}
