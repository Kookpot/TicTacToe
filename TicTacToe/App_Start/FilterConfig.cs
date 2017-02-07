using System.Web.Mvc;

namespace TicTacToe
{
    /// <summary>
    /// basic filter config
    /// </summary>
    public class FilterConfig
    {
        #region Public Methods

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        #endregion
    }
}