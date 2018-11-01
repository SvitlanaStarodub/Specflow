using System;
using System.Collections.Generic;
using System.Configuration;
using Common.Context;
using Common.Core;
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
            _mobilePageContext.SelectAppleVersion(phoneProducer);
        }

        [When(@"I open characteristics for '(.*)' phone versions")]
        public void WhenIOpenCharacteristicsForPhoneVersion(List<string> phoneVersions)
        {
            foreach (var version in phoneVersions)
            {
                _filterResultPageContext.NavigateToAppleVersion();
                _phoneCharacteristicsPageContext.NavigateToCharacteristicsPage();
                var phone1Characteristics = _phoneCharacteristicsPageContext.PhoneDetails();
                ScenarioContext.Current.Add(version, phone1Characteristics);

            }
         }

        [When(@"I compare characteristics for '(.*)' and '(.*)' phone versions")]
        public void WhenICompareCharacteristicsForAndPhoneVersions(string phoneVersion1, string phoneVersion2)
        {
            var detailsPhoneSeven = ScenarioContext.Current.Get<List<string>>(phoneVersion1);
            var detailsPhoneSevenPlus = ScenarioContext.Current.Get<List<string>>(phoneVersion2);


        }


        

        [When(@"On the page as a result I see products related to selected phone version '(.*)'")]
        public void WhenOnThePageAsAResultISeeProductsRelatedToSelectedPhoneVersion(string p0)
        {
            ScenarioContext.Current.Pending();
        }



        //[When(@"I select a phone as '(.*)' and phone version '(.*)'")]
        //public void WhenISelectAPhoneAsAndPhoneVersion(string phoneProducer, string phoneVersion)
        //{
        //    _mobilePageContext.SelectProducer(phoneProducer);
        //    _mobilePageContext.SelectAppleVersion(phoneVersion);

        //}

        //[Then(@"I see the page headline '(.*)' is displayed")]
        //public void ThenISeeThePageHeadlineIsDisplayed(string expectedHeadline)
        //{
        //    var actualHeadline = _filterResultPageContext.GetHeadelineAfterFiltering();
        //    Assert.AreEqual(expectedHeadline, actualHeadline);
        //}

        //[Then(@"On the page as a result I see products related to selected phone version '(.*)'")]
        //public void ThenOnThePageAsAResultISeeProductsRelatedToSelectedPhoneVersion(string expectedPhoneVersion)
        //{
        //    var actualResult = _filterResultPageContext.GetHeadelineAfterFiltering();

        //    foreach (var listElements in actualResult)
        //    {
        //        actualResult.Should().StartWith(expectedPhoneVersion);
        //    }
           

        //}





        [OneTimeTearDown]
        public void TearDown()  
        {
            _driver.Quit();
        }

    }
}
