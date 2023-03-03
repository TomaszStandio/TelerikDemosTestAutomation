using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TelerikDemosTestAutomation.Extension;
using TelerikDemosTestAutomation.Steps.Grid;

namespace TelerikDemosTestAutomation.Views
{
    public class BaseView
    {
        public IWebDriver Driver;
        public IWebElement WebElement;
        public void InitializationDriver(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public void GoToPage(string url, By cssSelector)
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();

            WaitTillDataIsLoading(cssSelector);
        }

        internal void WaitTillDataIsLoading(By cssSelector)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(cssSelector));
        }

        internal void WaitTillElementExist(By cssSelector)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(cssSelector));
        }

    }
}
