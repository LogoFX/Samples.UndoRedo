using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleInjector;
using LogoFX.Client.Mvvm.ViewModel.Contracts;
using LogoFX.Client.Mvvm.ViewModel.Services;
using LogoFX.Client.Mvvm.ViewModelFactory.SimpleInjector;
using LogoFX.Samples.Client.Presentation.Shell.ViewModels;

namespace LogoFX.Samples.Client.Presentation.Shell
{
    /// <summary>
    /// Entry point for the app. The bootstrapper is responsible for 
    /// all initial setup and displaying the root view bound to its data context.
    /// The bootstrapper will work with any IoC container adapter, making replacing 
    /// the IoC container easier.
    /// </summary>
    class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, SimpleInjectorAdapter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBootstrapper"/> class.
        /// The container is created here to allow greater control on how it is created
        /// and support possible integration tests where the container is passed as a 
        /// parameter as well
        /// </summary>
        public AppBootstrapper()
            :base(new SimpleInjectorAdapter())
        {
            
        }

        protected override void OnConfigure(SimpleInjectorAdapter container)
        {
            base.OnConfigure(container);
            container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();
            container.RegisterSingleton<IViewModelCreatorService, ViewModelCreatorService>();
        }
    }
}
