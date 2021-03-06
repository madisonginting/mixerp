// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetRoleIdByUseIdTests
    {
        public static GetRoleIdByUseIdController Fixture()
        {
            GetRoleIdByUseIdController controller = new GetRoleIdByUseIdController(new GetRoleIdByUseIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetRoleIdByUseIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}