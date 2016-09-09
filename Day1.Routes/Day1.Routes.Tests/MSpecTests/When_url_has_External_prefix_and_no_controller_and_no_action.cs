using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Day1.Routes.Tests.MSpecTests
{
    [Subject("Rote named 'DefaultExternal'")]
    class When_url_has_External_prefix_and_no_controller_and_no_action : BaseTest
    {
        Because of = () =>
        {
            TestHelper.ProcessAction(contextMock, routes, "~/External", out actualRote);
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
        };
    }
}
