using LojaVirtual.BLL.Departamentos.Dtos;

namespace LojaVirtual.BLL.Departamentos
{
    public interface IPersistirDepartamento
    {
        Departamento Armazenar(DepartamentoDto dto);
    }
}
