using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace allure_nunit.tests
{
    [AllureNUnit(false)]
    [AllureParentSuite("Root Suite")]
    public class BaseTest
    {
        // [OneTimeSetUp]
        public void CleanupResultDirectory()
        {
            AllureExtensions.WrapSetUpTearDownParams(() => { AllureLifecycle.Instance.CleanupResultDirectory(); },
                "Clear Allure Results Directory");
        }

        public void name(string value)
        {
            AllureLifecycle.Instance.UpdateTestCase(result =>
            {
                result.name = value;
            });
        }
    }
}