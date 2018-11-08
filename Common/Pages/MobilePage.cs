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
    class MobilePage
    {
       private readonly IWebDriver _driver;
       
        public MobilePage(IWebDriver driver)
        {
           _driver = driver;
        }
       
        [FindsBy(How = How.CssSelector, Using = "div[name='filter_parameters'] ul#sort_series li")]
        public IList<IWebElement> AppleVersionFilter;

        //[FindsBy(How = How.CssSelector, Using = "li[id^='filter_producer'] i")]
        //public IList<IWebElement> ListPhoneProducers;

        [FindsBy(How = How.CssSelector, Using = "li[id^='filter_producer'] a[name='producer_69']")]
        public IWebElement ListPhoneProducers;

        //=> ElementExtentions.WaitForExists(()=> _driver.FindElement(By.XPath($".//li[.//i[contains(text(),'{producer}')]]")));

    }
}
