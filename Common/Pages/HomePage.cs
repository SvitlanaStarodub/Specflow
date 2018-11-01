using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Catalog => _driver.FindElement(By.CssSelector("a[href*='telefony-tv-i-ehlektronika']"));
        //public IWebElement SubCatalog => _driver.FindElement(By.XPath(".//a[contains(text(),'Смартфоны')]"));

        public IWebElement MobileNavigation => _driver.FindElement(By.XPath(".//a[contains(text(),'Мобильные телефоны')]"));



    }
}
