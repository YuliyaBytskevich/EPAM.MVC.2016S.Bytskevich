using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'Optional' - test 2")]
    class When_url_is_Home_Sum_and_parameters_are_decimal : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Sum/10/20", out actualRote);
        };

        It should_process_request_without_exceptions = () =>
        {
            actualRote.ShouldNotBeNull();
            actualRote.Values["controller"].ShouldEqual("Home");
            actualRote.Values["action"].ShouldEqual("Sum");
            actualRote.Values["a"].ShouldEqual("10");
            actualRote.Values["b"].ShouldEqual("20");
        };
    }
}
