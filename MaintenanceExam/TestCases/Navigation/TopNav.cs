using MaintenanceExam.PageObjects;
using NUnit.Framework;

namespace MaintenanceExam.TestCases.Navigation
{
    class TopNav : BaseTestLocal
    {
        [Test]
        [Category("Navigation")]
        public void TopNavCase()
        {
            TopNavPanel topNavPanel = new TopNavPanel(Driver.Value!);
            topNavPanel.ProductsServices();
            string[] actualMenuItems = topNavPanel.GetSecondLevelMenuItems();
            // Update the test case to incorporate the new requirements and pass.
            // DONE: The top nav options have been updated.
            string[] expectedMenuItems = { "Checking & Savings", "Loans & Credit", "Home Loans", "Account Services", "Insurance", "Investments", "Business", "Schedule Appointment" };
            CollectionAssert.AreEqual(expectedMenuItems, actualMenuItems, "Verify second level of top nav menu");
        }
    }
}