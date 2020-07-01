﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLFlow.NET.Lib.Model.Responses.RegisteredModel
{
    public class CreateModelRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
