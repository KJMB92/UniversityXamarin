using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.App.DTOs
{
    public class LoginReqDTO
    {
        [JsonProperty("email")]
        public string Email{ get; set; }

        [JsonProperty("password")]
        public string password { get; set; }
    }
    public class LoginResDTO
    {   
        [JsonProperty("token")]
        public string Token{ get; set; }
    }
    public class LoginResFailDTO
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
