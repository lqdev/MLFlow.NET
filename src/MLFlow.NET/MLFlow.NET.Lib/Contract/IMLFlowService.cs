﻿using System.Threading.Tasks;
using MLFlow.NET.Lib.Model;
using MLFlow.NET.Lib.Model.Responses.Experiment;
using MLFlow.NET.Lib.Model.Responses.Run;
using MLFlow.NET.Lib.Model.Responses.RegisteredModel;

namespace MLFlow.NET.Lib.Contract
{
    public interface IMLFlowService
    {
        Task<CreateResponse> CreateExperiment(string name,
            string artifact_location = null);

        Task<RunResponse> CreateRun(CreateRunRequest request);

        Task<LogMetric> LogMetric(string run_uuid,
            string key, float value, long? timeStamp = null);

        Task<LogParam> LogParameter(string run_uuid,
            string key, string value);

        Task<ListExperimentsResponse> ListExperiments(ViewType viewtype);
        Task<GetExperimentResponse> GetExperiment(int experiment_id);

        Task<CreateResponse> GetOrCreateExperiment(
            string name,
            string artifact_location = null);

        // Models
        Task<CreateModelResponse> CreateRegisteredModel(string name);

        Task<GetModelResponse> GetRegisteredModel(string name);
    }
}