using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'WithCompoundRouteConstraint' - test 1")]
    class When_url_is_Home_Index_and_id_is_string : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Index/lalala", out actualRote);
        };

        It should_not_find_suitable_rote = () =>
        {
            actualRote.ShouldBeNull();
        };
    }
}
