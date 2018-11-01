using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Pages;
using OpenQA.Selenium;

namespace Common.Context
{
    public class MobilePageContext
    {
        private readonly MobilePage _mobilePage;
        
        public MobilePageContext(IWebDriver driver)
        {
            _mobilePage = new MobilePage(driver);
           
        }

        public void SelectProducer(string phoneProducer)
        {
           _mobilePage.PhoneApple.Click();
           
        }

        public void SelectAppleVersion(string phoneVersion)
        {
            var appleVersion = _mobilePage.AppleVersionFilter.First(element => element.Text == phoneVersion);
            appleVersion.Click();
        }
    }
}
