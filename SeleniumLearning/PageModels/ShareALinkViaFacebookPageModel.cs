using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class ShareALinkViaFacebookPageModel : TestBase
    {
        public ShareALinkViaFacebookPageModel(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region properties
        public IWebElement EmailAddress
        {
            get { return driver.FindElement(By.CssSelector("input[id=email]")); }
        }
        public IWebElement Password
        {
            get { return driver.FindElement(By.Id("pass")); }
        }

        #endregion

        #region Methods
        public void EnterEmail(String email)
        {
            EmailAddress.SendKeys(email);

        }
        #endregion
    }
}
