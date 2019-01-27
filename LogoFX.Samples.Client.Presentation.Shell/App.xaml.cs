using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using LogoFX.Client.Mvvm.Commanding;
using LogoFX.Client.Mvvm.ViewModel.Services;
using LogoFX.Client.Mvvm.ViewModelFactory.SimpleContainer;
using Solid.Core;

namespace LogoFX.Samples.Client.Presentation.Shell
{
    partial class App
    {
        public App()
        {
            var bootstrapper = new AppBootstrapper(new ExtendedSimpleContainerAdapter());
            bootstrapper.UseResolver().UseCommanding().UseViewModelCreatorService().UseViewModelFactory();
            ((IInitializable) bootstrapper).Initialize();            
        }
    }
}
