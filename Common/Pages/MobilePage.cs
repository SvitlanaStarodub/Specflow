using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common.Pages
{
    class MobilePage
    {
       private readonly IWebDriver _driver;

        public MobilePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement PhoneApple => _driver.FindElement(By.XPath(".//li[.//i[contains(text(),'Apple')]]"));

        public IReadOnlyCollection<IWebElement> AppleVersionFilter => _driver.FindElements(By.CssSelector("div[name='filter_parameters'] ul#sort_series li"));



    }
}
