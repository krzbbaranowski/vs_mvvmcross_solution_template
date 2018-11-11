using AutoMapper;

namespace XamarinMvvmCrossTemplate.Core.Infrastructure.Mapper
{
    public class MapperConfigurator
    {
        public static MapperConfiguration InitializeProfiles()
        {
            return new MapperConfiguration(cfg =>
            {
                //e.g.
                //cfg.AddProfile(new CustomerProfile());
            });
        }
    }
}