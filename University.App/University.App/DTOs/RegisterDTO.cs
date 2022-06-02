using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.App.DTOs
{
    public class RegisterReqDTO
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }
    }
    public class RegisterResDTO
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
    public class RegisterResFailDTO
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
