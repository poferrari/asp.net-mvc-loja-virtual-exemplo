using LojaVirtual.BLL.Municipios.Dtos;
using LojaVirtual.BLL.Pessoas;
using LojaVirtual.BLL.Pessoas.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class PessoasController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoasController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        public ActionResult Index()
        {
            var pessoas = _pessoaRepositorio.GetAll();
            return View();
        }

        public ActionResult Create()
        {
            CarregarUFs();
            CarregarMunicipios();
            return View();
        }

        [HttpPost]
        public ActionResult Create(PessoaDto dto)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            CarregarUFs();
            CarregarMunicipios(dto.UFId);
            return View(dto);
        }

        [HttpPost]
        [AllowAnonymous]        
        public JsonResult ObterMunicipios(int ufId)
        {
            var lst = RetornarMunicipios(ufId);
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        private void CarregarUFs()
        {
            ViewBag.Ufs = new List<UFDto>
            {
                new UFDto
                {
                    Id = 1,
                    Sigla = "PR"
                },
                new UFDto
                {
                    Id = 2,
                    Sigla = "SP"
                },
                new UFDto
                {
                    Id = 3,
                    Sigla = "CE"
                },
                new UFDto
                {
                    Id = 4,
                    Sigla = "AM"
                },
                new UFDto
                {
                    Id = 5,
                    Sigla = "MS"
                },
            }.OrderBy(t => t.Sigla).ToList();
        }

        private void CarregarMunicipios(int ufId = 0)
        {
            ViewBag.Municipios = RetornarMunicipios(ufId);
        }

        private List<MunicipioDto> RetornarMunicipios(int ufId)
        {
            return new List<MunicipioDto>
            {
                new MunicipioDto
                {
                    Id = 1,
                    Nome = "Londrina",
                    UfId = 1
                },
                new MunicipioDto
                {
                    Id = 2,
                    Nome = "Maringá",
                    UfId = 1
                },
                new MunicipioDto
                {
                    Id = 3,
                    Nome = "São Paulo",
                    UfId = 2
                }
            }.Where(t => t.UfId == ufId).OrderBy(t => t.Nome).ToList();
        }
    }
}