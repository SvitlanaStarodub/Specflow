using System;
using System.Configuration;
using Common.Context;
using Common.Core;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace BDD_Specflow.Steps
{
    [Binding]
    public class IPhoneSearchSteps
    {
        private readonly MobilePageContext _mobilePageContext;
        private readonly IWebDriver _driver;

        public IPhoneSearchSteps()
        {
            _driver = SeleniumDriver.Driver;
        }

        [Given(@"As an user, I open Mobile Phone tab on Rozetka")]
        public void GivenAsAnUserIOpenMobilePhoneTabOnRozetka()
        {
            var url = ConfigurationSettings.AppSettings["homeUrl"];
            _driver.Navigate().GoToUrl(url);

           
           
        }

    }
}
