﻿using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'WithCompoundRouteConstraint' - test 2")]
    class When_url_is_Home_Index_and_id_is_zero : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Index/0", out actualRote);
        };

        It should_not_find_suitable_rote = () =>
        {
            actualRote.ShouldBeNull();
        };
    }
}
