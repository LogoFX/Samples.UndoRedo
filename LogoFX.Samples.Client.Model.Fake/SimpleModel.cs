using LogoFX.Client.Mvvm.Model;
using LogoFX.Samples.Client.Model.Contracts;

namespace LogoFX.Samples.Client.Model.Fake
{
    class SimpleModel : EditableModel.WithUndoRedo, ISimpleModel
    {
        private string _name;
        public new string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                {
                    return;
                }
                MakeDirty();
                _name = value;
                NotifyOfPropertyChange();
            }
        }
                 
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age == value)
                {
                    return;
                }
                MakeDirty();
                _age = value;
                NotifyOfPropertyChange();
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address == value)
                {
                    return;
                }
                MakeDirty();
                _address = value;
                NotifyOfPropertyChange();
            }
        }
    }
}
