using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MLFlow.NET.Lib.Model.Responses.RegisteredModel
{
    public class CreateModelResponse
    {
        [JsonProperty("registered_model")]
        public RegisteredModel RegisteredModel { get; set; }
    }
}
