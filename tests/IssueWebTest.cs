using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace allure_nunit.tests
{
    public class TestTest : BaseTest
    {
        [Test]
        public void TestDummy()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
