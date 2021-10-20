using System;
using System.Threading.Tasks;
using CollegeVS.Models.API;

namespace CollegeVS.Services
{
    public interface IAuthStore
    {
        Task<UserSessionState> Login(string username, string password);

    }
}
