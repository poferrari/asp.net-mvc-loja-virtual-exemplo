using AutoMapper;
using LojaVirtual.BLL.Departamentos;
using LojaVirtual.BLL.Departamentos.Dtos;

namespace LojaVirtual.Infra.Configuracoes
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Departamento, DepartamentoDto>()
                .ForMember(d => d.Id, o => o.MapFrom(t => t.Id))
                .ForMember(d => d.Nome, o => o.MapFrom(t => t.Nome))
                .ForMember(d => d.Descricao, o => o.MapFrom(t => t.Descricao));
        }
    }
}
