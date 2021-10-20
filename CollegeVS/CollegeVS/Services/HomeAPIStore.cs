using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CollegeVS.Models.API;
using CollegeVS.Models.API.HelperClasses;
using CollegeVS.Models.DTOs;
using Microsoft.Extensions.Logging;
using Xamarin.Essentials;

namespace CollegeVS.Services
{
    public class HomeAPIStore: IHomeAPIStore
    {
        private ILogger<HomeAPIStore> logger;
        private HttpClient client;

        public HomeAPIStore( ILogger<HomeAPIStore> logger, IHttpClientFactory httpClientFactory = null)
        {
            this.logger = logger;
            client = httpClientFactory == null ? new HttpClient() : httpClientFactory.CreateClient("authController");
            client.BaseAddress = new Uri("http://192.168.1.154:1794/api/");
        }

        public UserSessionState State { get; set; }
        public CLGVSHomeModel HomeModel { get; set; }



        public async Task<CLGVSHomeModel> GetCLGVSHome(ContentLoadFilter contentLoadFilter = CVUtilities.DEFAULT_HOME_PAGE_FILTER, SortContentBy sortContentBy = SortContentBy.DATE_DESC)
        {
            CLGVSHomeModel res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress+ "HomeApi/GetCLGVSHome"),
                Method = HttpMethod.Get
            };

            RequestDTO<UserSessionState, ContentLoadFilter, SortContentBy> requestDTO = new RequestDTO<UserSessionState, ContentLoadFilter, SortContentBy>
            {
                First = State,
                Second = contentLoadFilter,
                Third = sortContentBy
            };

            request.Content = new StringContent(JsonSerializer.Serialize< RequestDTO<UserSessionState, ContentLoadFilter, SortContentBy>>(requestDTO), System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<CLGVSHomeModel>(content, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.CurrentUser.Username);
                    }

                }
            }
            catch (Exception e)
            {

            }

            
            return res;
        }

        public async Task<CLGVSHomeModel> GetCLGVSProfile(int desired_user_id, ContentLoadFilter contentLoadFilter = CVUtilities.DEFAULT_HOME_PAGE_FILTER, SortContentBy sortContentBy = SortContentBy.DATE_DESC)
        {
            ResponseDTO<CLGVSHomeModel> res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + "HomeApi/GetCLGVSProfile"),
                Method = HttpMethod.Get
            };

            RequestDTO<UserSessionState, int, ContentLoadFilter, SortContentBy> requestDTO = new RequestDTO<UserSessionState, int, ContentLoadFilter, SortContentBy>
            {
                First = State,
                Second = desired_user_id,
                Third = contentLoadFilter,
                Fourth = sortContentBy
            };

            request.Content = new StringContent(JsonSerializer.Serialize(requestDTO), System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO<CLGVSHomeModel>>(content, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);
                        Console.WriteLine(res.Obj.CurrentUser.Username);
                    }

                }
            }
            catch (Exception e)
            {

            }
            return res.Obj;
        }

        public async Task<CLGVSHomeModel> CLGVSDares(int desired_user_id, DareLoadFilter dareLoadFilter)
        {
            ResponseDTO<CLGVSHomeModel> res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + "HomeApi/CLGVSDares"),
                Method = HttpMethod.Get
            };

            RequestDTO<UserSessionState, int, DareLoadFilter> requestDTO = new RequestDTO<UserSessionState, int, DareLoadFilter>
            {
                First = State,
                Second = desired_user_id,
                Third = dareLoadFilter
            };

            request.Content = new StringContent(JsonSerializer.Serialize(requestDTO), System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO<CLGVSHomeModel>>(content, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);
                        Console.WriteLine(res.Obj.DareWrappers);
                    }

                }
            }
            catch (Exception e)
            {

            }
            return res.Obj;
        }

        public async Task<CLGVSHomeModel> GetCLGVSSchool(int school_id, ContentLoadFilter contentFilter, SortContentBy sortContentBy)
        {
            ResponseDTO<CLGVSHomeModel> res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + "HomeApi/GetCLGVSSchool"),
                Method = HttpMethod.Get
            };

            RequestDTO<UserSessionState, int, ContentLoadFilter, SortContentBy> requestDTO = new RequestDTO<UserSessionState, int, ContentLoadFilter, SortContentBy>
            {
                First = State,
                Second = school_id,
                Third = contentFilter,
                Fourth =sortContentBy
            };

            request.Content = new StringContent(JsonSerializer.Serialize(requestDTO), System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO<CLGVSHomeModel>>(content, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);
                        Console.WriteLine(res.Obj.PageType);
                    }

                }
            }
            catch (Exception e)
            {

            }
            return res.Obj;
        }

        public async Task<CLGVSHomeModel> GetTheData<T>( T obj, string url, HttpMethod method)
        {
            ResponseDTO<CLGVSHomeModel> res = null;
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + url),
                Method = method
            };

            request.Content = new StringContent(JsonSerializer.Serialize(obj), System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO<CLGVSHomeModel>>(content, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);
                        Console.WriteLine(res.Obj.PageType);
                    }

                }
            }
            catch (Exception e)
            {

            }
            return res.Obj;

        }

        public async Task<CLGVSHomeModel> CLGVSDareNotificationsIncoming(DareLoadFilter dareLoadFilter, int desired_user_id)
        {
            RequestDTO<UserSessionState, DareLoadFilter, int> requestDTO = new RequestDTO<UserSessionState, DareLoadFilter, int>
            {
                First = State,
                Second = dareLoadFilter,
                Third = desired_user_id
            };

            return await GetTheData(requestDTO, "HomeApi/CLGVSDareNotificationsIncoming", HttpMethod.Get);
        }
        public async Task<CLGVSHomeModel> CLGVSDareNotificationsOutgoing(DareLoadFilter dareLoadFilter, int desired_user_id)
        {
            RequestDTO<UserSessionState, DareLoadFilter, int> requestDTO = new RequestDTO<UserSessionState, DareLoadFilter, int>
            {
                First = State,
                Second = dareLoadFilter,
                Third = desired_user_id
            };

            return await GetTheData(requestDTO, "HomeApi/CLGVSDareNotificationsOutgoing", HttpMethod.Get);
        }
        public async Task<VideoWrapper> CLGVSSingleContent(int video_id)
        {
            ResponseDTO<VideoWrapper> res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/CLGVSSingleContent/{video_id}"),
                Method = HttpMethod.Get,
                
            };

            

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(content);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO<VideoWrapper>>(content, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);
                        Console.WriteLine(res.Obj);
                    }

                }
            }
            catch (Exception e)
            {

            }
            return res.Obj;

        }

        public async Task<bool> UploadPost(PostDTO post)
        {

            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/UploadVideo"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StreamContent(await post.File.OpenReadAsync()),
                "file", post.File.FileName);
            content.Add(new StringContent(post.PostTitle),
                "title");
            content.Add(new StringContent(post.UploaderUsername),
                "Name");
            content.Add(new StringContent(post.Category),
                "Category");
            content.Add(new StringContent(post.SchoolName),
                "schoolName");
            content.Add(new StringContent(post.SchoolID.ToString()),
                "schoolID");
            content.Add(new StringContent(post.IsDareAttempt.ToString()),
                "DareAttempt");
            content.Add(new StringContent(post.DareID.ToString()),
                "DareID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);
                        
                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;



        }

        public async Task<bool> UploadDare(DareUploadDTO post)
        { 

            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/DareCreated"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StreamContent(await post.File.OpenReadAsync()),
                "file", post.File.FileName);
            content.Add(new StringContent(post.ContentTitle),
                "contentTitle");
            content.Add(new StringContent(post.UploaderUsername),
                "uploaderUsername");
            content.Add(new StringContent(post.Category),
                "Category");
            content.Add(new StringContent(post.SchoolName),
                "schoolName");
            content.Add(new StringContent(post.SchoolID.ToString()),
                "school_id");
            content.Add(new StringContent(post.ContentContextText),
                "contentContextText");
            content.Add(new StringContent(post.RxUsername),
                "RxUsername");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;

        }

        public async Task<bool> DareDenied(int DareID, int RxUserID, int TxUserID)
        {
            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/DareDenied"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(DareID.ToString()),
                "DareId");
            content.Add(new StringContent(RxUserID.ToString()),
                "RxUserID");
            content.Add(new StringContent(TxUserID.ToString()),
                "TxUserID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;
        }

        public async Task<bool> DareAccepted(int DareID, int RxUserID, int TxUserID)
        {
            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/DareAccepted"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(DareID.ToString()),
                "DareId");
            content.Add(new StringContent(RxUserID.ToString()),
                "RxUserID");
            content.Add(new StringContent(TxUserID.ToString()),
                "TxUserID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;
        }

        public async Task<bool> DareBackout(int DareID, int RxUserID, int TxUserID)
        {
            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/DareBackout"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(DareID.ToString()),
                "DareId");
            content.Add(new StringContent(RxUserID.ToString()),
                "RxUserID");
            content.Add(new StringContent(TxUserID.ToString()),
                "TxUserID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;
        }

        public async Task<bool> DareAttempted(int DareID, int RxUserID, int TxUserID, int ContentID)
        {
            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/DareAttempted"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(DareID.ToString()),
                "DareId");
            content.Add(new StringContent(RxUserID.ToString()),
                "RxUserID");
            content.Add(new StringContent(TxUserID.ToString()),
                "TxUserID");
            content.Add(new StringContent(ContentID.ToString()),
                "ContentID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;
        }

        public async Task<bool> DareDeniedResponse(int DareID, int RxUserID, int TxUserID)
        {
            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/DeniedResponse"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(DareID.ToString()),
                "DareId");
            content.Add(new StringContent(RxUserID.ToString()),
                "RxUserID");
            content.Add(new StringContent(TxUserID.ToString()),
                "TxUserID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;
        }
        public async Task<bool> DareAcceptedResponse(int DareID, int RxUserID, int TxUserID)
        {
            ResponseDTO res = null;

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + $"HomeApi/AcceptedResponse"),
                Method = HttpMethod.Post,

            };

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(DareID.ToString()),
                "DareId");
            content.Add(new StringContent(RxUserID.ToString()),
                "RxUserID");
            content.Add(new StringContent(TxUserID.ToString()),
                "TxUserID");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string rescontent = await response.Content.ReadAsStringAsync();
                    logger.LogInformation(rescontent);

                    var settings = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    res = JsonSerializer.Deserialize<ResponseDTO>(rescontent, settings);
                    if (res != null)
                    {
                        Console.WriteLine(res.Response);

                    }

                }
            }
            catch (Exception e)
            {

            }
            return res != null;
        }



    }
}
