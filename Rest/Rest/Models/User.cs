using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rest.Models
{
    public class User
    {
        [JsonProperty("email")]
        public string Email { set; get; }
        [JsonProperty("password")]
        public string Password { set; get; }
    }
}
