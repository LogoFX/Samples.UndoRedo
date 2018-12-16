using System.Windows.Input;
using JetBrains.Annotations;
using LogoFX.Client.Mvvm.Commanding;
using LogoFX.Client.Mvvm.ViewModel.Extensions;
using LogoFX.Samples.Client.Model.Contracts;

namespace LogoFX.Samples.Client.Presentation.Shell.ViewModels
{
    [UsedImplicitly]
    public partial class SimpleEditorViewModel : ScreenObjectViewModel<ISimpleModel>
    {
        public SimpleEditorViewModel(IDataService dataService)
        {
            Model = dataService.CreateSimpleModel();
        }

        private ICommand _undoCommand;
        public ICommand UndoCommand => _undoCommand ?? (_undoCommand = ActionCommand.When(() => Model.CanUndo)
                                           .Do(() => Model.Undo())
                                           .RequeryOnPropertyChanged(this, () => Model.CanUndo));

        private ICommand _redoCommand;
        public ICommand RedoCommand => _redoCommand ?? (_redoCommand = ActionCommand.When(() => Model.CanRedo)
                                           .Do(() => Model.Redo())
                                           .RequeryOnPropertyChanged(this, () => Model.CanRedo));
    }
}