using LogoFX.Client.Mvvm.Model;
using LogoFX.Samples.Client.Model.Contracts;

namespace LogoFX.Samples.Client.Model.Fake
{
    class SimpleModel : EditableModel.WithUndoRedo, ISimpleModel
    {
        private string _name;
        public new string Name
        {
            get => _name;
            set
            {
                if (_name == value)
                {
                    return;
                }
                SetProperty(ref _name, value);
            }
        }
                 
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (_age == value)
                {
                    return;
                }
                SetProperty(ref _age, value);
            }
        }

        private string _address;
        public string Address
        {
            get => _address;
            set
            {
                if (_address == value)
                {
                    return;
                }
                SetProperty(ref _address, value);
            }
        }
    }
}
