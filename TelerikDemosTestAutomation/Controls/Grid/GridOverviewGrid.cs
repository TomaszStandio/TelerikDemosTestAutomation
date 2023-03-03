using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikDemosTestAutomation.CssSelectors.Grid;
using TelerikDemosTestAutomation.Views.Grid;

namespace TelerikDemosTestAutomation.Controls.Grid
{
    public class GridOverviewGrid: IGrid
    {
        private IWebElement webElement;

        

        public GridOverviewGrid(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public GridOverviewHeader Header => new GridOverviewHeader(webElement.FindElement(GridOverviewSelectors.Header));

        public IRow[] GetAllRows => webElement.FindElements(GridOverviewSelectors.Row).Select(x => new GridOverviewRow(x)).ToArray();

        public bool Displayed() => webElement.Displayed;

        public int GetColumnIndex(string columnName) => throw new NotImplementedException();

        public IWebElement GetElement(By searchBox) => webElement.FindElement(searchBox);

        public IWebElement[] GetElements(By searchBox) => webElement.FindElements(searchBox).ToArray();
        
        public IRow GetRow(int rowIndex) => GetAllRows[rowIndex];
        
        public bool IsGridEmpty() => GetAllRows.Length <= 0;
        
    }
}
