using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExemploErroNaoMapeado()
        {
            throw new Exception(
                "Exemplo envolvendo o lançamento de uma exceção não mapeada.");
        }

        [HandleError(ExceptionType = typeof(InvalidOperationException),
            View = "OperacaoInvalida")]
        [HandleError(ExceptionType = typeof(HttpException),
            View = "SolicitacaoHTTPInvalida")]
        public ActionResult ExemploMapeamentoErros()
        {
            if (new Random().Next(1, 3) == 1)
            {
                throw new InvalidOperationException(
                    "Exemplo de operação inválida.");
            }
            else
            {
                throw new HttpException(
                    "Exemplo de processamento de solicitação HTTP inválida.");
            }
        }
    }
}