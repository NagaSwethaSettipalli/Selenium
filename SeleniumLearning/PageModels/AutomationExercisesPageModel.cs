using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumLearning
{
    public class AutomationExercisesPageModel : TestBase
    {
        public AutomationExercisesPageModel(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region properties

        public IWebElement BigpagewithmanyelementsLink
        {
            get { return driver.FindElement(By.LinkText("Big page with many elements")); }
        }
        public IWebElement FakeLandingPageLink
        {
            get { return driver.FindElement(By.LinkText("Fake Landing Page")); }
        }
        public IWebElement FakePricingPageLink
        {
            get { return driver.FindElement(By.LinkText("Fake Pricing Page")); }
        }
        public IWebElement FilloutformsLink
        {
            get { return driver.FindElement(By.LinkText("Fill out forms")); }
        }
        public IWebElement LearnhowtoautomateanapplicationLink
        {
            get { return driver.FindElement(By.LinkText("Learn how to automate an application that evolves over time")); }
        }
        public IWebElement LoginautomationLink
        {
            get { return driver.FindElement(By.LinkText("Login automation")); }
        }
        public IWebElement Interactionswithsimpleelements
        {
            get { return driver.FindElement(By.LinkText("Interactions with simple elements")); }
        }
        #endregion

    }
}
