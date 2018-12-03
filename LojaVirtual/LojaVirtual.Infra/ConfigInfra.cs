using LojaVirtual.Infra.Configuracoes;

namespace LojaVirtual.Infra
{
    public static class ConfigInfra
    {
        public static void Iniciar()
        {
            AutoMapperConfiguration.Initialize();
        }
    }
}
