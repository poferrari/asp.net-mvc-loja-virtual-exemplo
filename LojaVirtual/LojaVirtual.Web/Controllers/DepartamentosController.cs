using AutoMapper;
using LojaVirtual.BLL.Departamentos;
using LojaVirtual.BLL.Departamentos.Dto;
using System.Linq;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class DepartamentosController : Controller
    {
        private readonly IDepartamentoRepositorio _departamentoRepositorio;
        private readonly IPersistirDepartamento _persistirDepartamento;
        private readonly IRemocaoDeDepartamento _remocaoDeDepartamento;

        public DepartamentosController(IDepartamentoRepositorio departamentoRepositorio,
            IPersistirDepartamento persistirDepartamento,
            IRemocaoDeDepartamento remocaoDeDepartamento
            )
        {
            _departamentoRepositorio = departamentoRepositorio;
            _persistirDepartamento = persistirDepartamento;
            _remocaoDeDepartamento = remocaoDeDepartamento;
        }
        
        public ActionResult Index()
        {
            var lista = _departamentoRepositorio.GetAll()
                .ToList();
            return View(lista);
        }

        public ActionResult Cadastro(int? id)
        {
            if (id == null)
                return View(new DepartamentoDto());

            var departamento = _departamentoRepositorio.Find(id);
            if (departamento == null)
                return HttpNotFound();
            var dto = Mapper.Map<Departamento, DepartamentoDto>(departamento);
            return View(dto);
        }

        [HttpPost]
        public ActionResult Cadastro(DepartamentoDto dto)
        {
            if (ModelState.IsValid)
            {
                var resultado = _persistirDepartamento.Armazenar(dto);
                if (resultado != null)
                    return RedirectToAction("Index");
            }
            return View(dto);
        }

        public ActionResult Remocao(int id)
        {
            _remocaoDeDepartamento.Remover(id);            
            return RedirectToAction("Index");
        }
    }
}