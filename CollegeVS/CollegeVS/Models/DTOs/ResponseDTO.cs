using System;
namespace CollegeVS.Models.DTOs
{
    public class ResponseDTO<T>
    {
        public string Response { get; set; }

        public T Obj { get; set; }
    }
    public class ResponseDTO
    {
        public string Response { get; set; }

        
    }
}
