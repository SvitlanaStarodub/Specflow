using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common.Pages
{
    public class PhoneCharacteristicsPage
    {
        private readonly IWebDriver _driver;

        public PhoneCharacteristicsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement CharacteristicTab =>
            _driver.FindElement(By.XPath(".//a[contains(text(),'Характеристики')]"));

        public List<IWebElement> PhoneDetails => _driver.FindElements(By.ClassName("chars-value-inner")).ToList();
    }
}
