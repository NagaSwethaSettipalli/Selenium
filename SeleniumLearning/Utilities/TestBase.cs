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
        public const string demourl = "https://ultimateqa.com/";
        public const string AutomationExerciseurl = "https://ultimateqa.com/automation/";

        [SetUp]
        public void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-infobars");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = demourl;

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
