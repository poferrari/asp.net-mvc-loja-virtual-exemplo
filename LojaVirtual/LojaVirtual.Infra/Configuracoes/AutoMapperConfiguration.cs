using AutoMapper;
using System;
using System.Collections.Generic;

namespace LojaVirtual.Infra.Configuracoes
{
    internal static class AutoMapperConfiguration
    {
        internal static IEnumerable<Type> GetAutoMapperProfiles()
        {
            var result = new List<Type>
            {
                typeof(MappingProfile),
            };
            return result;
        }

        internal static void Initialize()
        {
            Mapper.Initialize((cfg) =>
            {
                cfg.AddProfiles(GetAutoMapperProfiles());
            });
        }
    }
}
