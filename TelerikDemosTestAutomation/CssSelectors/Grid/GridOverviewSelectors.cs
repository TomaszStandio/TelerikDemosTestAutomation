using OpenQA.Selenium;


namespace TelerikDemosTestAutomation.CssSelectors.Grid
{
    public static class GridOverviewSelectors
    {
        public static By SearchBox => By.CssSelector("input[class='k-input-inner']");
        public static By Grid => By.CssSelector("div[id='grid']");
        public static By Row => By.CssSelector("tbody[role='rowgroup']>tr[role='row']");
        public static By Cell => By.CssSelector("td[role='gridcell']");
        public static By ProductName => By.CssSelector("div[class='product-name']");
        public static By CloseButtonGroupBy => By.CssSelector("span[class='k-button-icon k-icon k-i-close']");
        public static By HeaderColumnActive => By.CssSelector("a[class='k-header-column-menu k-active']");
        public static By Header => By.CssSelector("div[class='k-grid-header']");
        public static By ColumnName => By.CssSelector("th[class='k-header k-filterable']");
    }
}
