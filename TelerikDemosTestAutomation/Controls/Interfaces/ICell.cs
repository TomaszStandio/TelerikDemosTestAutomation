using OpenQA.Selenium;

namespace TelerikDemosTestAutomation.Controls.Grid
{
    public interface ICell
    {
        void Click();

        IWebElement GetElement(By searchBy);

        IWebElement[] GetElements(By searchBy);

        string Text { get; }
    }
}