using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{    
    public class ErrorController : Controller
    {        
        public ActionResult Index()
        {
            ViewBag.AlertaErro = "Ocorreu um Erro :(";
            ViewBag.MensagemErro = "Tente novamente ou contate o administrador do sistema.";
            return View();
        }

        public ActionResult NotFound()
        {
            ViewBag.AlertaErro = "Ocorreu um Erro :(";
            ViewBag.MensagemErro = "Não existe uma página para a URL informada.";
            return View("Index");
        }

        public ActionResult AccessDenied()
        {
            ViewBag.AlertaErro = "Acesso Negado :(";
            ViewBag.MensagemErro = "Você não tem permissão para executar isso";
            return PartialView("Index");
        }
    }
}