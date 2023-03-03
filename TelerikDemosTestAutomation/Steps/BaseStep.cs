using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;
using TelerikDemosTestAutomation.Views;

namespace TelerikDemosTestAutomation.Steps
{
    [Binding]

    public class BaseStep
    {
        internal static IWebDriver Driver;
        public static BaseView BaseView;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            LoadDriver();
            BaseView = new BaseView();
            BaseView.InitializationDriver(Driver);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Quit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

        }

        private static void LoadDriver()
        {
            Driver = new EdgeDriver();
        }
    }
}
