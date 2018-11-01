using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common.Pages
{
    public class FilterResultPage
    {
        private readonly IWebDriver _driver;

        public FilterResultPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public List<IWebElement> listOfPhones => _driver.FindElements(By.XPath(".//div[@class='g - i - tile - i - title clearfix']/a")).ToList();
    }
}
