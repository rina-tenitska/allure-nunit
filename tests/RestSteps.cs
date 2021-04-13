using NUnit.Allure.Steps;

namespace allure_nunit.tests
{
    public class RestSteps
    {
        [AllureStep("Create issue with title `{2}`")]
        public void CreateIssueWithTitle(string owner, string repo, string title)
        {
        }

        [AllureStep("Close issue with title `{2}`")]
        public void CloseIssueWithTitle(string owner, string repo, string title)
        {
        }

        [AllureStep("Check note with content `{2}` exists")]
        public void ShouldSeeIssueWithTitle(string owner, string repo, string title)
        {
        }

    }
}