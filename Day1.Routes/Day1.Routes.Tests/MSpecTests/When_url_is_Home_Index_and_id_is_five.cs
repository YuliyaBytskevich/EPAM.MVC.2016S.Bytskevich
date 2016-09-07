using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'WithCompoundRouteConstraint' - test 3")]
    class When_url_is_Home_Index_and_id_is_five : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Index/5", out actualRote);
        };

        It should_get_suitable_rote_from_default_namespace = () =>
        {
            actualRote.ShouldNotBeNull();
            actualRote.Values["controller"].ShouldEqual("Home");
            actualRote.Values["action"].ShouldEqual("Index");
            actualRote.Values["id"].ShouldEqual("5");
        };
    }
}
