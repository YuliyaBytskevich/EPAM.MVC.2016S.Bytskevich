using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'WithCompoundRouteConstraintAndCustomNamespace' - test 1")]
    class When_url_is_Home_Index_and_id_is_one_thousand_one : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/Home/Index/1001", out actualRote);
        };

        It should_get_Home_Index_rote_from_custom_namespace = () =>
        {
            actualRote.ShouldNotBeNull();
            object nsObject;
            actualRote.DataTokens.TryGetValue("namespaces", out nsObject);
            string currentNamespace = ((string[])nsObject)[0];
            currentNamespace.ShouldNotBeNull();
            currentNamespace.ShouldEqual("ExternalControllersLibrary");
            actualRote.Values["controller"].ShouldEqual("Home");
            actualRote.Values["action"].ShouldEqual("Index");
            actualRote.Values["id"].ShouldEqual("1001");
        };
    }
}
