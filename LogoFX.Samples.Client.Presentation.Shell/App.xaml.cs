using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleInjector;
using LogoFX.Client.Mvvm.ViewModel.Services;

namespace LogoFX.Samples.Client.Presentation.Shell
{
    partial class App
    {
        public App()
        {
            var bootstrapper = new AppBootstrapper(new SimpleInjectorAdapter());
            bootstrapper.UseResolver().UseViewModelCreatorService().Initialize();
        }
    }
}
