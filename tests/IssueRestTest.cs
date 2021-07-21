using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace allure_nunit.tests
{
    public class TestTest1 : BaseTest
    {
        [Test]
        public void TestDummy1()
        {
            Assert.Equals(1, 1);
        }
    }
}
