using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Common.Pages;
using OpenQA.Selenium;

namespace Common.Context
{
    public class FilterResultPageContext
    {
        private readonly FilterResultPage _filterResultPage;

        public FilterResultPageContext(IWebDriver driver)
        {
            _filterResultPage = new FilterResultPage(driver);
        }

        public void NavigateToAppleVersion(int index = 0)
        {
             _filterResultPage.listOfPhones[index].Click();

        }
    }
}
