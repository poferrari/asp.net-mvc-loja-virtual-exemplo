using LojaVirtual.BLL.Departamentos.Dto;

namespace LojaVirtual.BLL.Departamentos
{
    public interface IPersistirDepartamento
    {
        Departamento Armazenar(DepartamentoDto dto);
    }
}
