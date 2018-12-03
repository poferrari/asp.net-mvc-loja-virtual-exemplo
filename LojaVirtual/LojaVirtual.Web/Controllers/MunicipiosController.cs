using LojaVirtual.BLL.Municipios;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class MunicipiosController : Controller
    {
        private readonly IMunicipioRepositorio _municipioRepositorio;

        public MunicipiosController(IMunicipioRepositorio municipioRepositorio)
        {
            _municipioRepositorio = municipioRepositorio;
        }

        [HttpGet]
        [AllowAnonymous]
        public JsonResult GetPorUF(int ufId)
        {
            var lst = _municipioRepositorio.SelecionarPorUfId(ufId);
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }
}