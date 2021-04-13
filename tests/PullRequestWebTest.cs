using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace allure_nunit.tests
{
    [AllureOwner("eroshenkoam")]
    [AllureLabel("layer", "web")]
    [AllureFeature("Pull Requests")]
    public class AllureSimpleTest : BaseTest
    {
        private WebSteps WebSteps = new();

        private const string Owner = "allure-framework";
        private const string Repo = "allure2";
        private const string Title = "First Note";
        
        [AllureTag("web", "regress", "smoke")]
        [AllureLabel("jira", "AE-1")]
        [AllureLabel("jira", "AE-2")]
        [AllureStory("Create new pull request")]
        [AllureLabel("microservice", "Billing")]
        [Test(Description = "Creating new issue for authorized user")]
        public void ShouldCreatePullRequest()
        {
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }
        
        [AllureTag("web", "regress")]
        [AllureLabel("jira", "AE-2")]
        [AllureStory("Close existing pull request")]
        [AllureLabel("microservice", "Repository")]
        [Test(Description = "Deleting existing issue for authorized user")]
        public void ShouldClosePullRequest()
        {
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }
        
    }
}