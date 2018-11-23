using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.Helper;
using Common.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Common.Context
{
    public class PhoneCharacteristicsPageContext
    {
        private readonly PhoneCharacteristicsPage _phoneCharacteristicsPage;

        public PhoneCharacteristicsPageContext(IWebDriver driver)
        {
            _phoneCharacteristicsPage = PageFactory.InitElements<PhoneCharacteristicsPage>(driver);
        }

        public void NavigateToCharacteristicsPage()
        {
            _phoneCharacteristicsPage.CharacteristicTab.Click();
        }

        public List<string> PhoneDetails()
        {
            var function = new Func<bool>(() => _phoneCharacteristicsPage.PhoneDetails.Any());

            function.WaitFor();
            return _phoneCharacteristicsPage.PhoneDetails.Select(el =>
            {
                 el.WaitForExists();
                Thread.Sleep(1000);
                 return el.Text;

            }).ToList();
        }
    }
}
