using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLFlow.NET.Lib.Model.Responses.RegisteredModel
{
    public class RegisteredModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("creation_timestamp")]
        public string CreationTimestamp { get; set; }
        
        [JsonProperty("last_updated_timestamp")]
        public string LastUpdatedTimestamp { get; set; }
        
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
