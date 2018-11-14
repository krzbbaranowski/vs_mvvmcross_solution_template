using System;
using AutoMapper;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using XamarinMvvmCrossTemplate.Core.Infrastructure.Mapper;
using XamarinMvvmCrossTemplate.Core.ViewModels;

namespace XamarinMvvmCrossTemplate.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IMapper>(MapperConfigurator.InitializeProfiles().CreateMapper());
            
            RegisterAppStart<FirstViewModel>();
        }
    }
}
