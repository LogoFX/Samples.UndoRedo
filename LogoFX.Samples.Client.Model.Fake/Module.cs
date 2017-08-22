using LogoFX.Samples.Client.Model.Contracts;
using Solid.Practices.IoC;
using Solid.Practices.Modularity;

namespace LogoFX.Samples.Client.Model.Fake
{    
    class Module : ICompositionModule<IDependencyRegistrator>
    {
        public void RegisterModule(IDependencyRegistrator iocContainer)
        {
            iocContainer.RegisterSingleton<IDataService, DataService>();
        }
    }
}
