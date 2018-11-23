using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.Helper;
using Common.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Common.Context
{
    public class FilterResultPageContext
    {
        private readonly FilterResultPage _filterResultPage;

        public FilterResultPageContext(IWebDriver driver)
        {
            _filterResultPage = PageFactory.InitElements<FilterResultPage>(driver);
        }

        public void NavigateToAppleVersion(string version)
        {
         Thread.Sleep(2000);
          _filterResultPage.listOfPhones.First(el => el.Text == version).Click();
        }

        public void OpenPhoneDetails()
        {
            _filterResultPage.PhoneDetails.WaitForExists();
            Thread.Sleep(2000);
            _filterResultPage.PhoneDetails.Click();
        }
    }
}
