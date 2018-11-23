using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common.Helper
{
    public static class ElementExtensions
    {
        
        public static void WaitForExists(this IWebElement element, int attempts = 3)
        {
            while (attempts-- > 0)
            {
                try
                {
                    string.IsNullOrWhiteSpace(element.Text);
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(1000);
                }
                
            }
        }

        public static void RetryHoverOver(Action action, Action actionToPerform)
        {
            int attempts = 3;
            while (attempts -->0)
            {
                try
                {
                    action();
                    actionToPerform();
                    break;
                }
                catch (Exception ex)
                {
                   Thread.Sleep(2000);

                }
                
            }
            
        }
    }
}
