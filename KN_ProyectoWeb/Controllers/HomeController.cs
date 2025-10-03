using KN_ProyectoWeb.Models;
using System.Web.Mvc;

namespace KN_ProyectoWeb.Controllers
{
    public class HomeController : Controller
    {
        #region Iniciar Sesion

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            return RedirectToAction("Principal", "Home");
        }

        #endregion

        #region Registro
        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registro(Usuario usuario)
        {
            return View();
        }
        #endregion

        #region Recuperar Acesso
        [HttpGet]
        public ActionResult RecuperarAcceso()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RecuperarAcceso(Usuario usuario)
        {
            return View();
        }
        #endregion


        [HttpGet]
        public ActionResult Principal()
        {
            return View();
        }

  
    }
}