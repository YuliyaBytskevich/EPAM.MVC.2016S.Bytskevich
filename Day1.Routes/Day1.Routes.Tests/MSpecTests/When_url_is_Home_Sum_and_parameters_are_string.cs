using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'Optional' - test 3")]
    class When_url_is_Home_Sum_and_parameters_are_string : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Sum/arg1/arg2", out actualRote);
        };

        It should_not_find_suitable_rote = () =>
        {
            actualRote.ShouldBeNull();
        };
    }
}
