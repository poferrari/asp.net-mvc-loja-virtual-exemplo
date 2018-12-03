using LojaVirtual.BLL.Departamentos.Dtos;

namespace LojaVirtual.BLL.Departamentos
{
    public class PersistirDepartamento : IPersistirDepartamento
    {
        private readonly IDepartamentoRepositorio _departamentoRepositorio;

        public PersistirDepartamento(IDepartamentoRepositorio departamentoRepositorio)
        {
            _departamentoRepositorio = departamentoRepositorio;
        }

        public Departamento Armazenar(DepartamentoDto dto)
        {
            Departamento departamento;
            if (dto.Id == 0)
            {
                departamento = new Departamento(dto.Nome, dto.Descricao);
            }
            else
            {
                departamento = _departamentoRepositorio.Find(dto.Id);

                departamento.AlterarNome(dto.Nome);
                departamento.AlterarDescricao(dto.Descricao);
            }

            if (dto.Id == 0)
                _departamentoRepositorio.Adicionar(departamento);

            _departamentoRepositorio.SalvarTodos();

            return departamento;
        }
    }
}
