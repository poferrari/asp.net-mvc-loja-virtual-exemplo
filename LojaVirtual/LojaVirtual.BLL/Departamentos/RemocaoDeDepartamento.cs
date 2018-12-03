namespace LojaVirtual.BLL.Departamentos
{
    public class RemocaoDeDepartamento : IRemocaoDeDepartamento
    {
        private readonly IDepartamentoRepositorio _departamentoRepositorio;

        public RemocaoDeDepartamento(IDepartamentoRepositorio departamentoRepositorio)
        {
            _departamentoRepositorio = departamentoRepositorio;
        }

        public void Remover(int id)
        {
            _departamentoRepositorio.Excluir(t => t.Id == id);
            _departamentoRepositorio.SalvarTodos();
        }
    }
}
