using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Helper;
using Common.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Common.Context
{
    public class HomePageContext
    {
        private readonly HomePage _homePage;
        private readonly IWebDriver _driver;
        
        public HomePageContext(IWebDriver driver)
        {
            _homePage = new HomePage(driver);
            _driver = driver;
            HelperWaiter.InitializeWaiter(driver, TimeSpan.FromSeconds(7));
        }

        public void NavigateToMobilePage()
        {
            Actions hoverOver = new Actions(_driver);
            hoverOver.MoveToElement(_homePage.Catalog).Perform();

            _homePage.MobileNavigation.WaitForDisplayed();
            _homePage.MobileNavigation.Click();

        }

    }
}
