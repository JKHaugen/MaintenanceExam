using MaintenanceExam.PageObjects;
using NUnit.Framework;

namespace MaintenanceExam.TestCases.InsuranceQuote
{
    class RequestAutoAndHomePersonalInsuranceQuoteInEnglish : BaseTestLocal
    {
        [Test]
        [Category("Insurance Quote")]
        public void RequestAutoAndHomePersonalInsuranceQuoteInEnglishCase()
        {
            // hack to get to the page faster
            Driver.Value!.Url = "https://www-qa.mybranchqa.org/insurance/personal/request-a-quote";

            // Update the test case to incorporate the new requirements and pass.
            // DONE: The insurance quote page has been updated to include Interest: Home and Language Preference,
            // the default language preference is "English".
            bool autoInterest = true;
            bool homeInterest = true;
            bool otherInterest = false;
            new GetAQuotePage(Driver.Value!).CreateRequest(autoInterest, homeInterest, otherInterest);

            // DONE: Add an assert in the test to validate the confirmation message after submission.
            string expectedConfirmation = "Thank you for your submission!";
            int timeoutInSeconds = 2;
            string actualConfirmation = new SubmittedQuotePage(Driver.Value!).GetSubmissionConfirmationMessage(timeoutInSeconds);
            Assert.AreEqual(expectedConfirmation, actualConfirmation, "Verify confirmation of submission of quote");
        }
    }
}