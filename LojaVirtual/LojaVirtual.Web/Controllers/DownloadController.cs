using System.IO;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class DownloadController : Controller
    {        
        [AllowAnonymous]
        public FileResult Index(string arquivo)
        {
            var caminho = Path.Combine(Server.MapPath("~/UploadedFiles"), arquivo);
            var contentType = "application/image";
            return File(caminho, contentType, arquivo);
        }
    }
}