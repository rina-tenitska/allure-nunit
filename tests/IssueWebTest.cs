using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace allure_nunit.tests
{
    [AllureOwner("eroshenkoam")]
    [AllureLabel("layer", "web")]
    [AllureFeature("Issues")]
    public class IssueWebTest : BaseTest
    {
        private WebSteps WebSteps = new();

        private const string Owner = "allure-framework";
        private const string Repo = "allure2";
        private const string Title = "First Note";
        
        [Test]
        [AllureTag("web", "critical")]
        [AllureLabel("jira", "AE-2")]
        [AllureStory("Create new issue")]
        [AllureLabel("microservice", "Billing")]
        public void ShouldCreateIssue()
        {
            name("Creating new issue authorized user");
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }
        
        [Test]
        [AllureTag("web", "regress")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Close existing issue")]
        [AllureLabel("microservice", "Repository")]
        public void ShouldAddLabelToIssue()
        {
            name("Adding note to advertisement");
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }

        [Test]
        [AllureTag("web", "regress")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Close existing issue")]
        [AllureLabel("microservice", "Repository")]
        public void ShouldCloseIssue()
        {
            name("Closing new issue for authorized user");
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.CloseIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }

    }
}