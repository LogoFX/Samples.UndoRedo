using LogoFX.Samples.Client.Model.Contracts;

namespace LogoFX.Samples.Client.Model.Fake
{
    class DataService : IDataService
    {
        public ISimpleModel CreateSimpleModel()
        {
            return new SimpleModel();
        }
    }
}
