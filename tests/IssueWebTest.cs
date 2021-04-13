using System;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
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
        
        [AllureTag("web", "critical")]
        [AllureLabel("jira", "AE-2")]
        [AllureStory("Create new issue")]
        [AllureLabel("microservice", "Billing")]
        [Test(Description = "Creating new issue authorized user")]
        public void ShouldCreateIssue()
        {
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }
        
        [AllureTag("web", "regress")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Close existing issue")]
        [AllureLabel("microservice", "Repository")]
        [Test(Description = "Adding note to advertisement")]
        public void ShouldAddLabelToIssue()
        {
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }
        [AllureTag("web", "regress")]
        [AllureLabel("jira", "AE-1")]
        [AllureStory("Close existing issue")]
        [AllureLabel("microservice", "Repository")]
        [Test(Description = "Closing new issue for authorized user")]
        public void ShouldCloseIssue()
        {
            WebSteps.OpenPullRequestsPage(Owner, Repo);
            WebSteps.CreateIssueWithTitle(Title);
            WebSteps.CloseIssueWithTitle(Title);
            WebSteps.ShouldSeeIssueWithTitle(Title);
        }

    }
}