using OpenQA.Selenium;

namespace TelerikDemosTestAutomation.Controls
{
    public class Button
    {
        IWebElement _webElement;
        public Button(IWebElement webElement)
        {
            _webElement = webElement;
        }

        public void Click() => _webElement.Click();
}
}
