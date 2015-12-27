using JetBrains.Annotations;
using LogoFX.Samples.Client.Model.Contracts;

namespace LogoFX.Samples.Client.Model.Fake
{
    [UsedImplicitly]
    class DataService : IDataService
    {
        public ISimpleModel CreateSimpleModel()
        {
            return new SimpleModel();
        }
    }
}
