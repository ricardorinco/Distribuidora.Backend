using AutoMapper;

namespace RR.Distribuidora.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => { x.AddProfile<ReverseMappingProfile>(); });
        }
    }
}
