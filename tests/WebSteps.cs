using System;
using NUnit.Allure.Steps;
using NUnit.Framework;

namespace allure_nunit.tests
{
    public class WebSteps
    {
        [AllureStep("Open issues page `{0}/{1}`")]
        public void OpenIssuePage(string owner, string repo)
        {
            MaybeThrowElementNotFoundException();
        }

        [AllureStep("Open pull requests page `{0}/{1}`")]
        public void OpenPullRequestsPage(string owner, string repo)
        {
            MaybeThrowElementNotFoundException();
        }

        [AllureStep("Create pull request from branch `{0}`")]
        public void CreatePullRequestFromBranch(string branch)
        {
            MaybeThrowElementNotFoundException();
        }

        [AllureStep("Create issue with title `{0}`")]
        public void CreateIssueWithTitle(string title)
        {
            MaybeThrowAssertionException(title);
        }

        [AllureStep("Close pull request for branch `{0}`")]
        public void ClosePullRequestForBranch(string branch)
        {
            MaybeThrowAssertionException(branch);
        }

        [AllureStep("Close issue with title `{0}`")]
        public void CloseIssueWithTitle(string title)
        {
            MaybeThrowAssertionException(title);
        }
        
        [AllureStep("Check pull request for branch `{0}` exists")]
        public void ShouldSeePullRequestForBranch(string branch)
        {
            MaybeThrowAssertionException(branch);
        }

        [AllureStep("Check pull request for branch `{0}` exists")]
        public void ShouldSeeIssueWithTitle(string title)
        {
            MaybeThrowAssertionException(title);
        }
        
        [AllureStep("Check pull request for branch `{0}` not exists")]
        public void ShouldNotSeePullRequestForBranch(string branch)
        {
            MaybeThrowAssertionException(branch);
        }

        [AllureStep("Check issue with title `{0}` not exists")]
        public void ShouldNotSeeIssueWithTitle(string title)
        {
            MaybeThrowAssertionException(title);
        }
        
        private void MaybeThrowSeleniumTimeoutException() {
            if (IsTimeToThrowException()) {
                Assert.Fail(WebDriverIsNotReachable("Allure"));
            }
        }

        private void MaybeThrowElementNotFoundException() {
            if (IsTimeToThrowException()) {
                Assert.Fail(ElementNotFoundMessage("[//div[@class='something']]"));
            }
        }

        private void MaybeThrowAssertionException(String text) {
            if (IsTimeToThrowException()) {
                Assert.Fail(TextEqual(text, "another text"));
            }
        }

        private bool IsTimeToThrowException() {
            return new Random().NextDouble() >= 0.85;
        }

        private string WebDriverIsNotReachable(string text) {
            return String.Format("WebDriverException: chrome not reachable\n" +
                                 "Element not found By.xpath: //a[@href='/eroshenkoam/allure-example']\n" +
                                 "Expected: text '{0}'\n" +
                                 "Page source: file:/.../build/reports/tests/1603973861960.0.html\n" +
                                 "Timeout: 4 s.", text);
        }

        private string TextEqual(String expected, String actual) {
            return String.Format("Element should text '{0}' By.xpath: //a[@href='/eroshenkoam/allure-example']\n" +
                                 "Element: '<a class=\"v-align-middle\">{1}</a>'\n" +
                                 "Screenshot: file:/.../build/reports/tests/1603973703632.0.png\n" +
                                 "Page source: file:/.../build/reports/tests/1603973703632.0.html\n" +
                                 "Timeout: 4 s.\n", expected, actual);
        }

        private string ElementNotFoundMessage(string selector) {
            return String.Format("Element not found By.xpath: {0}\n" +
                                 "Expected: visible or transparent: visible or have css value opacity=0\n" +
                                 "Screenshot: file:/.../build/reports/tests/1603973516437.0.png\n" +
                                 "Page source: file:/.../build/reports/tests/1603973516437.0.html\n" +
                                 "Timeout: 4 s.\n", selector);
        }
    }
}