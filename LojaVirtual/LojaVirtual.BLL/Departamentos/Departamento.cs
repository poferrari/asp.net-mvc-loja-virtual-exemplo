using LojaVirtual.BLL._Base;

namespace LojaVirtual.BLL.Departamentos
{
    public class Departamento : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public Departamento() { }

        public Departamento(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }
    }
}
