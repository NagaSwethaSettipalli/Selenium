using NUnit.Framework;

namespace SeleniumLearning.Tests
{
   public class UltimateQAHomePageTests : TestBase
    {
        private UltimateQAHomePageModel ultimateQAHomePage;
        private AutomationExercisesPageModel AutomationExercisesPage;

     [SetUp]
     public void TestInitialize()
        {
            SetupDriver();
            ultimateQAHomePage = new UltimateQAHomePageModel(driver);
            AutomationExercisesPage = new AutomationExercisesPageModel(driver);
        }


        [TestCase]
        public void GivenUltimteQAHomePage_WhenClickedOnAutomationExercisesTab_ThenAutomationExercisesPageOpens()
        {
            ultimateQAHomePage.ClickOnAutomationExercisestab();
            Assert.True(driver.Url.Equals(AutomationExerciseurl));
        }
    }
}
