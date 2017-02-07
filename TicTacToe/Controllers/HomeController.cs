using System.Web.Mvc;

namespace TicTacToe.Controllers
{
    /// <summary>
    /// defult home controller
    /// </summary>
    public class HomeController : Controller
    {
        #region Public Methods

        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}