using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Pages;
using OpenQA.Selenium;

namespace Common.Context
{
    public class PhoneCharacteristicsPageContext
    {
        private readonly PhoneCharacteristicsPage _phoneCharacteristicsPage;

        public PhoneCharacteristicsPageContext(IWebDriver driver)
        {
            _phoneCharacteristicsPage = new PhoneCharacteristicsPage(driver);
        }

        public void NavigateToCharacteristicsPage()
        {
            _phoneCharacteristicsPage.CharacteristicTab.Click();
        }

        public List<string> PhoneDetails()
        {
            return _phoneCharacteristicsPage.PhoneDetails.Select(el => el.Text).ToList();
        }
    }
}
