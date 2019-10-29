namespace Rest.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AccessToken
    {
        [JsonProperty("token")]
        public string Value { get; set; }
    }
}