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
        
        [AllureTag("api", "smoke")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Create new issue")]
        [AllureLabel("microservice", "Billing")]
        [Test(Description = "Create issue via api")]
        public void ShouldCreateUserNote()
        {
            RestSteps.CreateIssueWithTitle(Owner, Repo, Title);
            RestSteps.ShouldSeeIssueWithTitle(Owner, Repo, Title);
        }
        
        [AllureTag("api", "regress")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Close existing issue")]
        [AllureLabel("microservice", "Repository")]
        [Test(Description = "Close existing issue")]
        public void ShouldDeleteUserNote()
        {
            RestSteps.CreateIssueWithTitle(Owner, Repo, Title);
            RestSteps.CloseIssueWithTitle(Owner, Repo, Title);
        }
    }
}