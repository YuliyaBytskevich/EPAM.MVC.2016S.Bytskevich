using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'Optional' - test 1")]
    public class When_url_is_Home_Sum_and_no_parameters_given: BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Sum", out actualRote);
        };

        It should_process_request_without_exceptions = () =>
        {
            actualRote.ShouldNotBeNull();
            actualRote.Values["controller"].ShouldEqual("Home");
            actualRote.Values["action"].ShouldEqual("Sum");
        };
    }
}
