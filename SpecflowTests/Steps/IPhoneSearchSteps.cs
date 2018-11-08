using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using Common.Context;
using Common.Core;
using Common.Helper;
using Common.Pages;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;


namespace SpecflowTests.Steps
{
    [Binding]
    public class IPhoneSearchSteps
    {
        private readonly HomePageContext _homePageContext;
        private readonly MobilePageContext _mobilePageContext;
        private readonly IWebDriver _driver;
        private readonly FilterResultPageContext _filterResultPageContext;
        private readonly PhoneCharacteristicsPageContext _phoneCharacteristicsPageContext;

       
        public IPhoneSearchSteps()
        {
            _driver = SeleniumDriver.Driver;
            _driver.Manage().Window.Maximize();
            _homePageContext = new HomePageContext(_driver);
            _mobilePageContext = new MobilePageContext(_driver);
            _filterResultPageContext = new FilterResultPageContext(_driver);
            _phoneCharacteristicsPageContext = new PhoneCharacteristicsPageContext(_driver);

        }

       [Given(@"As an user, I open Mobile Phone tab on Rozetka")]
        public void GivenAsAnUserIOpenMobilePhoneTabOnRozetka()
        {
            var url = ConfigurationSettings.AppSettings["homeUrl"];
            _driver.Navigate().GoToUrl(url);
            
           _homePageContext.NavigateToMobilePage();
            
        }

        [Given(@"I select a phone as '(.*)'")]
        public void GivenISelectAPhoneAs(string phoneProducer)
        {
            _mobilePageContext.SelectProducer(phoneProducer);
        }

        [When(@"I open characteristics for '(.*)' phone versions")]
       public void WhenIOpenCharacteristicsForPhoneVersion(List<string> phoneVersions)
        {
            Thread.Sleep(1000);

            var url = _driver.Url;

            foreach (var version in phoneVersions)
            {
               
                _filterResultPageContext.NavigateToAppleVersion(version);
                _filterResultPageContext.OpenPhoneDetails();
                _phoneCharacteristicsPageContext.NavigateToCharacteristicsPage();
                var phone1Characteristics = _phoneCharacteristicsPageContext.PhoneDetails();
                ScenarioContext.Current.Add(version, phone1Characteristics);
                _driver.Navigate().GoToUrl(url);
               
            }
        }

        [Then(@"I compare characteristics for '(.*)' and '(.*)' phone versions")]
        public void WhenICompareCharacteristicsForAndPhoneVersions(string phoneVersion1, string phoneVersion2)
        {
            var detailsPhoneSeven = ScenarioContext.Current.Get<List<string>>(phoneVersion1);
            var detailsPhoneSevenPlus = ScenarioContext.Current.Get<List<string>>(phoneVersion2);
           
            var commonPhoneDetails = detailsPhoneSevenPlus.Intersect(detailsPhoneSeven);
            ScenarioContext.Current.Add(ScenarioContextKeys.commonDetailsKey, commonPhoneDetails);
            
        }

        [Then(@"I save common phone details to a file")]
        public void ThenISaveCommonPhoneDetailsToAFile()
        {

            var enumerable = ScenarioContext.Current.Get<IEnumerable<string>>(ScenarioContextKeys.commonDetailsKey);
            string path = @"D:\";
            string fileName = "Common.txt";

            File.WriteAllLines(Path.Combine(path, fileName), enumerable);

        }


        [AfterScenario]
        public void TearDown()  
        {
            _driver.Quit();
        }

    }
}
