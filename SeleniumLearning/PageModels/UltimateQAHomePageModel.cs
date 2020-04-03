using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniumLearning
{
    public class UltimateQAHomePageModel : TestBase
    {
        public UltimateQAHomePageModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region properties
        public IWebElement Coursestab
        {
            get { return driver.FindElement(By.LinkText("Courses")); }
        }
        public IWebElement SeleniumResourcestab
        {
            get { return driver.FindElement(By.LinkText("Selenium Resources")); }
        }
        public IWebElement AutomationExercisestab
        {
            get { return driver.FindElement(By.LinkText("Automation Exercises")); }
        }
        public IWebElement Podcasttab
        {
            get { return driver.FindElement(By.LinkText("Podcast")); }
        }
        public IWebElement Blogtab
        {
            get { return driver.FindElement(By.LinkText("Blog")); }
        }
        public IWebElement UltimateQAtab
        {
            get { return driver.FindElement(By.LinkText("Ultimate QA")); }
        }
        public IWebElement TopSearchIcon
        {
            get { return driver.FindElement(By.Id("et_search_icon")); }
        }
        public IWebElement FacebookIcon
        {
            get { return driver.FindElement(By.ClassName("sw swp_facebook_icon")); }
        }
        public IWebElement TwitterIcon
        {
            get { return driver.FindElement(By.ClassName("sw swp_twitter_icon")); }
        }
        public IWebElement ShareIcon
        {
            get { return driver.FindElement(By.ClassName("sw swp_tumblr_icon")); }
        }
        public IWebElement LinkedinIcon
        {
            get { return driver.FindElement(By.ClassName("sw swp_linkedin_icon")); }
        }
        public IWebElement EmailIcon
        {
            get { return driver.FindElement(By.ClassName("sw swp_email_icon")); }
        }
        #endregion

        #region methods
        public AutomationExercisesPageModel ClickOnAutomationExercisestab()
        {
            AutomationExercisestab.Click();
            return new AutomationExercisesPageModel(driver);
        }
        #endregion methods
    }
}

