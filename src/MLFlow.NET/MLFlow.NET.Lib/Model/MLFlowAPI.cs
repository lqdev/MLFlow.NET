﻿using System.Runtime.InteropServices;

namespace MLFlow.NET.Lib.Model
{
    public class MLFlowAPI
    {

        public class Experiments
        {
            public const string BasePath = "experiments";
            public const string Create = "create";
            public const string List = "list";
            public const string Get = "get";
            
        }
        public class Runs
        {
            public const string BasePath = "runs";
            public const string Create = "create";
            public const string LogMetric = "log-metric";
            public const string LogParam = "log-parameter";
        }

        public class RegisteredModels
        {
            public const string BasePath = "registered-models";
            public const string Create = "create";
            public const string Get = "get";
        }
    }
}
