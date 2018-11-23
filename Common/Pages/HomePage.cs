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
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;

            
        }



        [FindsBy(How = How.CssSelector, Using = "a[href*='telefony-tv-i-ehlektronika']")]
        public IWebElement Catalog;
       
        [FindsBy(How =How.XPath, Using = ".//a[contains(text(),'Мобильные телефоны')]")]
        public IWebElement MobileNavigation;

       //public IWebElement MobileNavigation => ElementExtentions.WaitForExists(_driver.FindElement, By.XPath(".//a[contains(text(),'Мобильные телефоны')]"));



    }
}
