using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'WithCompoundRouteConstraintAndCustomNamespace' - test 3")]
    class When_url_is_Home_Index_and_id_is_two_thousands_one : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Index/2001", out actualRote);
        };

        It should_not_find_suitable_rote = () =>
        {
            actualRote.ShouldBeNull();
        };
    }
}
