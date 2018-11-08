using System;
using System.Collections.Generic;
using System.IO;
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
    public class MobilePageContext
    {
        private readonly MobilePage _mobilePage;
        
        public MobilePageContext(IWebDriver driver)
        {
           _mobilePage = PageFactory.InitElements<MobilePage>(driver);
        }

        public void SelectProducer(string phoneProducer)
        {
            Thread.Sleep(2000);
            //var producers = _mobilePage.ListPhoneProducers.WaitForExists();
          _mobilePage.ListPhoneProducers .Click();
            //_mobilePage.ListPhoneProducers.First(el => el.Text == phoneProducer);

        }

        public void SelectAppleVersion(string phoneVersion)
        {
            var collection = _mobilePage.AppleVersionFilter.ToList();
            var appleVersion = _mobilePage.AppleVersionFilter.First(element => element.Text == phoneVersion);
            appleVersion.Click();
        }
    }
}
