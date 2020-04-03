using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class LoginAutomationPageModel : TestBase
    {
        public LoginAutomationPageModel(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
