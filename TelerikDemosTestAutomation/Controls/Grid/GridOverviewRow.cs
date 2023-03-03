using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikDemosTestAutomation.CssSelectors.Grid;

namespace TelerikDemosTestAutomation.Controls.Grid
{
    public class GridOverviewRow : IRow
    {
        private IWebElement webElement;

        public GridOverviewRow(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public ICell[] GetCells => webElement.FindElements(GridOverviewSelectors.Cell).Select(x => new GridOverviewCell(x)).ToArray();

        public GridOverviewCell Cell => throw new NotImplementedException();

        public ICell GetCell(int columnIndex) => GetCells[columnIndex];

        public IWebElement GetElement(By searchBy) => webElement.FindElement(searchBy);

        public IWebElement[] GetWebElements(By searchBy) => webElement.FindElements(searchBy).ToArray();

    }
}
