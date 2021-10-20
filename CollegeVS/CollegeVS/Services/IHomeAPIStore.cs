using System;
using System.Threading.Tasks;
using CollegeVS.Models.API;
using CollegeVS.Models.API.HelperClasses;
using CollegeVS.Models.DTOs;

namespace CollegeVS.Services
{
    public interface IHomeAPIStore
    {
        UserSessionState State { get; set; }
        CLGVSHomeModel HomeModel { get; set; }

        public Task<CLGVSHomeModel> GetCLGVSHome(ContentLoadFilter contentLoadFilter, SortContentBy sortContentBy);

        public Task<CLGVSHomeModel> GetCLGVSProfile(int desired_user_id, ContentLoadFilter contentLoadFilter, SortContentBy sortContentBy);

        public Task<CLGVSHomeModel> CLGVSDares(int desired_user_id, DareLoadFilter dareLoadFilter);

        public Task<CLGVSHomeModel> GetCLGVSSchool(int school_id, ContentLoadFilter contentFilter, SortContentBy sortContentBy);

        public Task<CLGVSHomeModel> CLGVSDareNotificationsIncoming(DareLoadFilter dareLoadFilter, int desired_user_id);

        public Task<CLGVSHomeModel> CLGVSDareNotificationsOutgoing(DareLoadFilter dareLoadFilter, int desired_user_id);

        public Task<VideoWrapper> CLGVSSingleContent(int video_id);

        public Task<bool> UploadPost(PostDTO post);

        public Task<bool> UploadDare(DareUploadDTO post);

        public Task<bool> DareDenied(int DareID, int RxUserID, int TxUserID);

        public Task<bool> DareAccepted(int DareID, int RxUserID, int TxUserID);

        public Task<bool> DareBackout(int DareID, int RxUserID, int TxUserID);
        public Task<bool> DareAttempted(int DareID, int RxUserID, int TxUserID, int ContentID);

        public Task<bool> DareDeniedResponse(int DareID, int RxUserID, int TxUserID);

        public Task<bool> DareAcceptedResponse(int DareID, int RxUserID, int TxUserID);



    }
}
