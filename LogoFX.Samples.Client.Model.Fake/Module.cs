using System.ComponentModel.Composition;
using LogoFX.Client.Bootstrapping.Adapters.SimpleInjector;
using LogoFX.Samples.Client.Model.Contracts;
using Solid.Practices.Modularity;

namespace LogoFX.Samples.Client.Model.Fake
{
    [Export(typeof(ICompositionModule))]
    class Module : ICompositionModule<SimpleInjectorAdapter>
    {
        public void RegisterModule(SimpleInjectorAdapter iocContainer)
        {
            iocContainer.RegisterSingleton<IDataService, DataService>();
        }
    }
}
