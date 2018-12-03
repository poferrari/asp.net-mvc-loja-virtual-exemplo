using LojaVirtual.BLL._Base;
using LojaVirtual.BLL.Municipios.Dtos;
using System.Collections.Generic;

namespace LojaVirtual.BLL.Municipios
{
    public interface IMunicipioRepositorio : IRepositorioBase<Municipio>
    {
        List<MunicipioDto> SelecionarPorUfId(int ufId);
    }
}
