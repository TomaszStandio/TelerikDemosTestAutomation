using OpenQA.Selenium;
using System.Linq;

namespace TelerikDemosTestAutomation.Controls.Grid
{
    public class GridOverviewCell : ICell
    {
        private IWebElement webElement;

        public GridOverviewCell(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public string Text => webElement.Text;

        public void Click() => webElement.Click();
        
        public IWebElement GetElement(By searchBy)
        {
            return webElement.FindElement(searchBy);
        }

        public IWebElement[] GetElements(By searchBy)
        {
            return webElement.FindElements(searchBy).ToArray();
        }
    }
}