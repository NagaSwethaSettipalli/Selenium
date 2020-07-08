using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class FillOutFormsPageModel : TestBase
    {
        public FillOutFormsPageModel(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region properties

        public IWebElement NameField1
        {
            get { return driver.FindElement(By.Id("et_pb_contact_name_0")); }
        }
        public IWebElement MessageField1
        {
            get { return driver.FindElement(By.Id("et_pb_contact_message_0")); }
        }
        public IWebElement Submitbutton1
        {
            get { return driver.FindElement(By.Id("et_pb_contact_form_0")).FindElement(By.Name("et_builder_submit_button")); }
        }
        public IWebElement NameField2
        {
            get { return driver.FindElement(By.Id("et_pb_contact_name_1")); }
        }
        public IWebElement MessageField2
        {
            get { return driver.FindElement(By.Id("et_pb_contact_message_1")); }
        }
        public IWebElement Submitbutton2
        {
            get { return driver.FindElement(By.Id("et_pb_contact_form_1")).FindElement(By.Name("et_builder_submit_button")); }
        }
        public IWebElement CaptchaTextBox
        {
            get { return driver.FindElement(By.ClassName("input et_pb_contact_captcha")); }
        }
        #endregion

    }
}
