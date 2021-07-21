using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace allure_nunit.tests
{
    public class TestTest : BaseTest
    {
        [Test]
        public void TestDummy()
        {
            Assert.Equals(1, 1);
        }
    }
}
