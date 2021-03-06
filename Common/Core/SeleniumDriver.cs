﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Common.Core
{
    public static class SeleniumDriver
    {
        private static IWebDriver _driver;
 
        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                    _driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
                }
                return _driver;
            }
            set { _driver = value; }
        }

    }
}
