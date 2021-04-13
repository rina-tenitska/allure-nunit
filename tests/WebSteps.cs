using NUnit.Allure.Steps;

namespace allure_nunit.tests
{
    public class WebSteps
    {
        [AllureStep("Open issues page `{0}/{1}`")]
        public void OpenIssuePage(string owner, string repo)
        {
        }

        [AllureStep("Open pull requests page `{0}/{1}`")]
        public void OpenPullRequestsPage(string owner, string repo)
        {
        }

        [AllureStep("Create pull request from branch `{0}`")]
        public void CreatePullRequestFromBranch(string branch)
        {
        }

        [AllureStep("Create issue with title `{0}`")]
        public void CreateIssueWithTitle(string title)
        {
        }

        [AllureStep("Close pull request for branch `{0}`")]
        public void ClosePullRequestForBranch(string title)
        {
        }

        [AllureStep("Close issue with title `{0}`")]
        public void CloseIssueWithTitle(string title)
        {
        }
        
        [AllureStep("Check pull request for branch `{0}` exists")]
        public void ShouldSeePullRequestForBranch(string branch)
        {
        }

        [AllureStep("Check pull request for branch `{0}` exists")]
        public void ShouldSeeIssueWithTitle(string branch)
        {
        }
        
        [AllureStep("Check pull request for branch `{0}` not exists")]
        public void ShouldNotSeePullRequestForBranch(string branch)
        {
        }

        [AllureStep("Check issue with title `{0}` not exists")]
        public void ShouldNotSeeIssueWithTitle(string branch)
        {
        }
    }
}