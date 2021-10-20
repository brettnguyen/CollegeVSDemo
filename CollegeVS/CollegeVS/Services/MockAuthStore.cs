using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CollegeVS.Models.API;
using CollegeVS.Models.DTOs;
using Microsoft.Extensions.Logging;

namespace CollegeVS.Services
{
    public class MockAuthStore: IAuthStore
    {
        ILogger<MockAuthStore> logger;
        
        public MockAuthStore(ILogger<MockAuthStore> logger)
        {
            this.logger = logger;
        }

        public Task<UserSessionState> Login(string username, string password)
        {
            

            UserSessionState state = new UserSessionState
            {
                Birthday = DateTime.Now,
                JoinDate = DateTime.Now,
                User_ID = 35,
                Email = "superChungus@gmail.com",
                First_Name = "Big",
                Last_Name = "Chungus",
                School = "A.T. Still University",
                School_Id = 10,
                Username = "superChungus",
                Valid_Login = true
            };

            throw new NotImplementedException();
            //return state;

        }
    }
}
