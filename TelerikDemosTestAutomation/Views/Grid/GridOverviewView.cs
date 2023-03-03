

using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.CacheStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using TechTalk.SpecFlow.CommonModels;
using TelerikDemosTestAutomation.Controls;
using TelerikDemosTestAutomation.Controls.Grid;
using TelerikDemosTestAutomation.CssSelectors.Grid;

namespace TelerikDemosTestAutomation.Views.Grid
{
    public sealed class GridOverviewView : BaseView
    {
        public const int productNameColumnId = 1;
        public const int firstRowWithData = 1;
        public GridOverviewGrid Grid => new GridOverviewGrid(Driver.FindElement(GridOverviewSelectors.Grid));
        public Button CloseButtonGroupBy => new Button(Driver.FindElement(GridOverviewSelectors.CloseButtonGroupBy));
        

        internal void EnterValueIntoSearchbox(string searchValue)
        {
            var searchBox = Grid.GetElement(GridOverviewSelectors.SearchBox);
            searchBox.SendKeys(searchValue);

            WaitTillElementExist(GridOverviewSelectors.HeaderColumnActive);          
        }

        public bool GridShowOnlySearchedElement(string searchValue)
        {
            
            bool result = false;
            var allRows = Grid.GetAllRows;

            foreach (var row in allRows)
            {
                var cellWithProductName = row.GetCell(productNameColumnId);
                var productNameText = cellWithProductName.Text.ToLower();

                if (productNameText.Contains(searchValue.ToLower()))
                {
                    result = true;
                    Console.WriteLine($"{productNameText} contains {searchValue}");
                }
                else
                {
                    result = false;
                    Console.WriteLine($"{productNameText} not contains {searchValue}");
                    break;
                }
            }

            return result;
        }

        public void DeleteAllGroupBy()
        {
            CloseButtonGroupBy.Click();
        }
    }
}
