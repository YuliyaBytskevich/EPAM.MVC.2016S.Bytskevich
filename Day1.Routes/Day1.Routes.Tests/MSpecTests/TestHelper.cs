using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;
using Machine.Specifications;
using Moq;
using It = Moq.It;

namespace Day1.Routes.Tests.MSpecTests
{
    public static class TestHelper
    {
        public static void InitializeTestContext(out RouteCollection routes, out Mock<HttpContextBase> contextMock)
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            contextMock = new Mock<HttpContextBase>();
        }

        public static void ProcessAction(Mock<HttpContextBase> contextMock, RouteCollection routes, string testUrl, out RouteData actualRote)
        {
            contextMock.Setup(x => x.Request.AppRelativeCurrentExecutionFilePath).Returns(testUrl);
            actualRote = routes.GetRouteData(contextMock.Object);
        }
    }
}
