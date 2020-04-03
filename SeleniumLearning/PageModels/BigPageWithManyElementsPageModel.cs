using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class BigPageWithManyElementsPageModel : TestBase
    {
        public BigPageWithManyElementsPageModel(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
