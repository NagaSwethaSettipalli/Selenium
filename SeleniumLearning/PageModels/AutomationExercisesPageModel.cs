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
        public IWebElement Bigpagewithmanyelements
        {
            get { return driver.FindElement(By.LinkText("Big page with many elements")); }
        }
      
    }
}
