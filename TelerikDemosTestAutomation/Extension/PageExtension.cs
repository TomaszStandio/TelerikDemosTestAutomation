using OpenQA.Selenium;
using TelerikDemosTestAutomation.Views;

namespace TelerikDemosTestAutomation.Extension
{
    public static class PageExtension
    {
        public static T GetPage<T>() where T : BaseView, new()
        {
            return new T();
        }
    }
}
