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
    public class PhoneCharacteristicsPage
    {
        private readonly IWebDriver _driver;

        public PhoneCharacteristicsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//a[contains(text(),'Характеристики')]")]
        public IWebElement CharacteristicTab;
        //=> ElementExtentions.WaitForExists(()=>
        //_driver.FindElement(By.XPath(".//a[contains(text(),'Характеристики')]")));

        [FindsBy(How = How.ClassName, Using = "chars-value-inner")]
        public IList<IWebElement> PhoneDetails;

        //=> ElementExtentions.WaitCollectionIsNotEmpty(_driver.FindElements,By.ClassName("chars-value-inner"));
    }
}
