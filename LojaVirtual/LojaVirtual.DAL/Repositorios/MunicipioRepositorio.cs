using LojaVirtual.BLL.Municipios;
using LojaVirtual.BLL.Municipios.Dtos;
using LojaVirtual.DAL._Base;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.DAL.Repositorios
{
    public class MunicipioRepositorio : RepositorioBase<Municipio>, IMunicipioRepositorio
    {
        public List<MunicipioDto> SelecionarPorUfId(int ufId)
        {
            return Get(t => t.UfId == ufId).Select(t => new MunicipioDto
            {
                Id = t.Id,
                Nome = t.Nome
            }).OrderBy(t => t.Nome).ToList();
        }
    }
}
