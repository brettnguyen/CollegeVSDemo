using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class UserAccountSetting
    {
        public int AccountSettingsID { get; set; }
        public int UserID { get; set; }
        public bool DisplayRealName { get; set; }
    }
}
