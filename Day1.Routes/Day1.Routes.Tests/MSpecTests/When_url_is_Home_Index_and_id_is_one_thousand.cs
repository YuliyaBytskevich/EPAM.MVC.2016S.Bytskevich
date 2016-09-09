using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'WithCompoundRouteConstraint' - test 4")]
    class When_url_is_Home_Index_and_id_is_one_thousand: BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Index/1000", out actualRote);
        };

        It should_get_Home_Index_rote_from_default_namespace = () =>
        {
            actualRote.ShouldNotBeNull();
            object nsObject;
            actualRote.DataTokens.TryGetValue("namespaces", out nsObject);
            string currentNamespace = ((string[])nsObject)[0];
            currentNamespace.ShouldNotBeNull();
            currentNamespace.ShouldEqual("Day1.Routes.Controllers");
            actualRote.Values["controller"].ShouldEqual("Home");
            actualRote.Values["action"].ShouldEqual("Index");
            actualRote.Values["id"].ShouldEqual("1000");
        };
    }
}
