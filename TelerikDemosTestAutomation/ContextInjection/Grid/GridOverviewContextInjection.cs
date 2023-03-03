using TelerikDemosTestAutomation.Views.Grid;

namespace TelerikDemosTestAutomation.Steps.Grid
{
    public class GridOverviewContextInjection
    {
        public GridOverviewView GridOverview { get; set; }
        public string SearchValue { get; internal set; }
    }
}