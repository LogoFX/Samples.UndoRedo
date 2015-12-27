using LogoFX.Client.Mvvm.Model.Contracts;

namespace LogoFX.Samples.Client.Model.Contracts
{
    public interface ISimpleModel : IModel, IEditableModel, IUndoRedo
    {        
        int Age { get; set; }
        string Address { get; set; }
    }
}
