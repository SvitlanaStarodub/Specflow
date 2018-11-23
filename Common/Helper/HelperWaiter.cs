using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Common.Helper
{
    public static class HelperWaiter
    {
        private static WebDriverWait _waiter;

        public static void InitializeWaiter(IWebDriver driver, TimeSpan timeSpan)
        {
            _waiter = new WebDriverWait(driver, timeSpan);
        }

        public static void WaitForEnabled(this IWebElement element)
        {
            Thread.Sleep(2000);
            //ElementExtentions.WaitForExists(() => element);
            _waiter.Until(driver => element.Enabled);
        }

        public static void WaitFor(this Func<bool> condition)
        {
            var functionResult = condition.Invoke();
            if (functionResult)
                return;
            
                Thread.Sleep(2000);
          
        }
    }
}
