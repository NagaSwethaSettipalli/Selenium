using NUnit.Framework;
using System.Threading;

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
        public void GivenUltimteQAHomePage_WhenClickedOnAutomatinExercisesTab_ThenAutomationExercisesPageOpens()
        {
            ultimateQAHomePage.ClickOnAutomationExercisestab();
            Assert.True(driver.Url.Equals(automationExerciseUrl));
        }

       /* [TestCase]
        public void GivenUltimateQAHomePage_WhenClickedOnhareViaFacebookLink_ThenFacebookLoginPageWindowOpens()
        {
           var fbPage = ultimateQAHomePage.ClickFacebookLink();
            
            fbPage.EmailAddress.SendKeys("abc@test.com");
            fbPage.Password.SendKeys("test123");
            Thread.Sleep(10000);
            
        }*/

    }
}
