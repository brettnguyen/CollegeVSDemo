using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CollegeVS.Models.API;
using CollegeVS.Models.DTOs;
using Microsoft.Extensions.Logging;

namespace CollegeVS.Services
{
    public class AuthStore: IAuthStore
    {
        ILogger<AuthStore> logger;
        HttpClient client;
        public AuthStore(ILogger<AuthStore> logger, IHttpClientFactory httpClientFactory = null)
        {
            this.logger = logger;
            client = httpClientFactory == null ? new HttpClient() : httpClientFactory.CreateClient("authController");
            client.BaseAddress = new Uri("http://192.168.1.154:1794/api/");
        }

        public async Task<UserSessionState> Login(string username, string password)
        {
            ResponseDTO<UserSessionState> res = null;

            UserSessionState state = null;
            try
            {
                HttpResponseMessage response = await client.PostAsync("auth/Login?username=User3&passw=password", null);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO<UserSessionState>>(content, settings);
                    state = res.Obj;
                }
            }
            catch (Exception e)
            {

            }

            
            return state;

        }
    }
}
