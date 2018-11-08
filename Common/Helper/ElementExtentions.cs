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
        //public static IWebElement WaitForExists(Func<IWebElement> action, int attempts = 3)
        //{
        //    IWebElement element = null;
        //    while (attempts-- > 0)
        //    {
        //        try
        //        {
        //            element = action();
        //            break;
        //        }
        //        catch (Exception ex) when (ex is NoSuchElementException || ex is StaleElementReferenceException)
        //        {
        //            Thread.Sleep(1000);
        //        }
        //    }

        //    return element;
        //}

        public static void WaitForExists(this IWebElement element, int attempts = 3)
        {
            while (attempts-- > 0)
            {
                try
                {
                    string.IsNullOrWhiteSpace(element.Text);
                    break;
                }
                catch (Exception ex) when (ex is NoSuchElementException || ex is StaleElementReferenceException || ex is ElementNotVisibleException)
                {
                    Thread.Sleep(1000);
                }
                
            }
        }

        public static List<IWebElement> WaitCollectionIsNotEmpty(Func<By, ReadOnlyCollection<IWebElement>> methodCallElementFunc, By selector, int attempts = 2)
        {
            while (attempts-- > 0)
            {
                 if (methodCallElementFunc.Invoke(selector).Count > 0)
                    break;

                Thread.Sleep(1000);
                
            }

            return methodCallElementFunc.Invoke(selector).ToList();
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
                catch (ElementNotVisibleException ex)
                {
                    Thread.Sleep(100);
                }
                
            }
            
        }
    }
}
