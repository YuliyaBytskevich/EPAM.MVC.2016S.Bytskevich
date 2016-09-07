using System.Web;
using System.Web.Routing;
using Machine.Specifications;
using Machine.Specifications.Model;
using MvcContrib.TestHelper;
using Moq;
using It = Machine.Specifications.It;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'Default'")]
    public class When_no_url_is_entered : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/", out actualRote);
        };

        It should_get_default_route = () =>
        {
            actualRote.ShouldNotBeNull();
            actualRote.Values["controller"].ShouldEqual("Home");
            actualRote.Values["action"].ShouldEqual("Index");
        };
    }
}
