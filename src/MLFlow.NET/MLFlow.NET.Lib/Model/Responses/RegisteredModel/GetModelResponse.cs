using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLFlow.NET.Lib.Model.Responses.RegisteredModel
{
    public class GetModelResponse
    {
        [JsonProperty("registered_model")]
        public RegisteredModel RegisteredModel { get; set; }
    }
}
