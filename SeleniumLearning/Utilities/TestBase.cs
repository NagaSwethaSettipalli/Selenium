using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace SeleniumLearning
{
    [TestFixture]
    public class TestBase : IDisposable
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        public const string demoUrl = "https://ultimateqa.com/";
        public const string automationExerciseUrl = "https://ultimateqa.com/automation/";
        public const string fakeLandingPageUrl = "https://ultimateqa.com/fake-landing-page";
        public const string bigPageWithManyElementsUrl = "https://ultimateqa.com/complicated-page";
        public const string fakePricingPageUrl = "https://ultimateqa.com/automation/fake-pricing-page/";
        public const string fillOutFormsPageUrl = "https://ultimateqa.com/filling-out-forms/";
        public const string learnHowToAutomatePageUrl = "https://ultimateqa.com/sample-application-lifecycle-sprint-1/";
        public const string loginAutomationPageUrl = "https://courses.ultimateqa.com/users/sign_in";
        public const string interactionsWithSimpleElementsPageUrl = "https://ultimateqa.com/simple-html-elements-for-automation/";
       
  
        [SetUp]
        public void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-infobars");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = demoUrl;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));               
        }

        public void Dispose()
        {
            if (driver != null)
                driver.Dispose();
        }

        //generic methods

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }
        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

    }
}
