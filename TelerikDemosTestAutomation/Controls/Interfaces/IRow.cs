using OpenQA.Selenium;

namespace TelerikDemosTestAutomation.Controls.Grid
{
    public interface IRow
    {
        IWebElement GetElement(By searchBy);

        IWebElement[] GetWebElements(By searchBy);

        ICell GetCell(int columnIndex);

        ICell[] GetCells { get; }

    }
}