using JetBrains.Annotations;
using LogoFX.Samples.Client.Model.Contracts;

namespace LogoFX.Samples.Client.Model.Fake
{
    [UsedImplicitly]
    internal sealed class DataService : IDataService
    {
        public ISimpleModel CreateSimpleModel()
        {
            return new SimpleModel();
        }
    }
}
