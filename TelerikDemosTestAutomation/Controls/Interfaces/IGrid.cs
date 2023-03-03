using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;

namespace TelerikDemosTestAutomation.Controls.Grid
{
    public interface IGrid
    {
        IWebElement GetElement(By searchBox);

        IWebElement[] GetElements(By searchBox);
        
        int GetColumnIndex(string columnName);
        
        IRow[] GetAllRows {  get; }
        
        IRow GetRow(int rowIndex);
        
        bool IsGridEmpty();
        
        bool Displayed();

    }
}