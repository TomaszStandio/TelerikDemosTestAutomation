using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TelerikDemosTestAutomation.CssSelectors.Grid;

namespace TelerikDemosTestAutomation.Views.Grid
{
    public class GridOverviewHeader
    {
        private IWebElement webElement;

        public GridOverviewHeader(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        public List<string> GetColumnName()
        {
            List<string> columnsName = new List<string>();
            var columns = webElement.FindElements(GridOverviewSelectors.ColumnName);

            foreach (var column in columns)
            {
                columnsName.Add(column.GetAttribute("data-title").ToString());
            }

            return columnsName;
        }

    }
}