using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class FakeLandingPageModel : TestBase
    {
        public FakeLandingPageModel(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
