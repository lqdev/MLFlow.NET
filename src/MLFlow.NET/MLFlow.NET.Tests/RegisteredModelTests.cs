using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLFlow.NET.Lib.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MLFlow.NET.Lib.Model.Responses.RegisteredModel;

namespace MLFlow.NET.Tests
{
    [TestClass]
    public class RegisteredModelTests : TestBase
    {
        [TestMethod]
        public async Task CreateRegisteredModel()
        {
            var mlFlowService = Resolve<IMLFlowService>();
            var model = await mlFlowService.CreateRegisteredModel("test");
            Assert.IsNull(model);
        }

        [TestMethod]
        public async Task GetRegisteredModel()
        {
            var mlFlowService = Resolve<IMLFlowService>();
            var model = await mlFlowService.GetRegisteredModel("test");
        }
    }
}
