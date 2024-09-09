using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MaintenanceExam.PageObjects
{
    public class SubmittedQuotePage : BasePageLocal
    {
        private readonly By _thankYouForSubmissionLocator = By.XPath("//h3[contains(text(),'submission')]");

        public SubmittedQuotePage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Grabs the thank you text after the submission of an insurance quote.
        /// </summary>
        /// <param name="timeout">Seconds of time to wait for submission to complete</param>
        /// <returns>String thanking the user for the submission</returns>
        public string GetSubmissionConfirmationMessage(int timeout)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementExists(_thankYouForSubmissionLocator));
            return GetText(_thankYouForSubmissionLocator);
        }
    }
}