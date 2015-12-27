using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleInjector;
using LogoFX.Client.Mvvm.ViewModel.Contracts;
using LogoFX.Client.Mvvm.ViewModel.Services;
using LogoFX.Client.Mvvm.ViewModelFactory.SimpleInjector;
using LogoFX.Samples.Client.Presentation.Shell.ViewModels;

namespace LogoFX.Samples.Client.Presentation.Shell
{
    class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, SimpleInjectorContainer>
    {
        public AppBootstrapper()
            :base(new SimpleInjectorContainer())
        {
            
        }

        protected override void OnConfigure(SimpleInjectorContainer container)
        {
            base.OnConfigure(container);
            container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();
            container.RegisterSingleton<IViewModelCreatorService, ViewModelCreatorService>();
        }
    }
}
