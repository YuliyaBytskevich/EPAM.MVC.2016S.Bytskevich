using System.Web;
using System.Web.Routing;
using Machine.Specifications;
using Moq;

namespace Day1.Routes.Tests.MSpecTests
{
    public class BaseTest
    {
        protected static RouteCollection routes;
        protected static Mock<HttpContextBase> contextMock;
        protected static RouteData actualRote;

        Establish context = () =>
        {
            TestHelper.InitializeTestContext(out routes, out contextMock);
        };
    }
}
