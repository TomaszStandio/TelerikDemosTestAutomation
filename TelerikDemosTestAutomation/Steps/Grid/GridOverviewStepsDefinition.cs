using JetBrains.Annotations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;
using TelerikDemosTestAutomation.CssSelectors.Grid;
using TelerikDemosTestAutomation.Extension;
using TelerikDemosTestAutomation.Views.Grid;

namespace TelerikDemosTestAutomation.Steps.Grid
{
    [Binding]
    [Scope(Feature = "GridOverview")]
    [UsedImplicitly]

    public class GridOverviewStepsDefinition : BaseStep
    {
        private GridOverviewContextInjection _gridOverviewContextInjection;

        public GridOverviewStepsDefinition(GridOverviewContextInjection gridOverviewContextInjection)
        {
            _gridOverviewContextInjection = gridOverviewContextInjection;
        }

        [Given(@"I am on Grid Overview Page")]
        public void GivenIAmOnGridOverviewPage()
        {
            BaseView.GoToPage(ConfigurationManager.AppSettings["GridOverviewUrl"], GridOverviewSelectors.Grid);
            _gridOverviewContextInjection.GridOverview = PageExtension.GetPage<GridOverviewView>();
            _gridOverviewContextInjection.GridOverview.Driver = BaseView.Driver;
            _gridOverviewContextInjection.GridOverview.DeleteAllGroupBy();

        }

        [When(@"I entered (.*) into searchbox")]
        public void WhenIEnteredTofuIntoSearchbox(string searchValue)
        {
            _gridOverviewContextInjection.GridOverview.EnterValueIntoSearchbox(searchValue);
            _gridOverviewContextInjection.SearchValue = searchValue;
        }

        [Then(@"Searched value is displayed")]
        public void ThenSearchedValueIsDisplayed()
        {
            Assert.True(_gridOverviewContextInjection.GridOverview.GridShowOnlySearchedElement(_gridOverviewContextInjection.SearchValue));
        }

        [Then(@"Table contains all column")]
        public void ThenTableContainsAllColumn(Table table)
        {
            List<string> expectedColumnsList = new List<string>();

            for (int i = 0; i < table.RowCount; i++)
            {
                var columnName = table.Rows[i].Values.ToArray();
                expectedColumnsList.Add(columnName[0].ToString());
            }

            var actualColumnList = _gridOverviewContextInjection.GridOverview.Grid.Header.GetColumnName();

            Assert.AreEqual(expectedColumnsList, actualColumnList, $"Columns name are not as expected");
        }


    }
}
