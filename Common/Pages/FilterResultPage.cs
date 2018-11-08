using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Common.Pages
{
    public class FilterResultPage
    {
        private readonly IWebDriver _driver;

        public FilterResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//li[starts-with(@class,'filter')]//span/i")]
        public IList<IWebElement> listOfPhones;
        //=> ElementExtentions.WaitCollectionIsNotEmpty(_driver.FindElements, By.XPath(".//li[starts-with(@class,'filter')]//span/i"));

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'g-i-tile-i-title clearfix')]/a")]
        public IWebElement PhoneDetails;

        //=> ElementExtentions.WaitForExists(()=>_driver.FindElement(By.XPath(".//div[contains(@class,'g-i-tile-i-title clearfix')]/a")));
    }
}
