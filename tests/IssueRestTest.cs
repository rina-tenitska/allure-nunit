using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace allure_nunit.tests
{
    [AllureOwner("baev")]
    [AllureFeature("Issues")]
    [AllureLabel("layer", "rest")]
    public class IssueRestTest : BaseTest
    {
        private RestSteps RestSteps = new();

        private const string Owner = "allure-framework";
        private const string Repo = "allure2";
        private const string Title = "First Note";
        
        [Test]
        [AllureTag("api", "smoke")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Create new issue")]
        [AllureLabel("microservice", "Billing")]
        public void ShouldCreateUserNote()
        {
            name("Create issue via api");
            RestSteps.CreateIssueWithTitle(Owner, Repo, Title);
            RestSteps.ShouldSeeIssueWithTitle(Owner, Repo, Title);
        }
        
        [Test]
        [AllureTag("api", "regress")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Close existing issue")]
        [AllureLabel("microservice", "Repository")]
        public void ShouldDeleteUserNote()
        {
            name("Close existing issue");
            RestSteps.CreateIssueWithTitle(Owner, Repo, Title);
            RestSteps.CloseIssueWithTitle(Owner, Repo, Title);
        }
    }
}