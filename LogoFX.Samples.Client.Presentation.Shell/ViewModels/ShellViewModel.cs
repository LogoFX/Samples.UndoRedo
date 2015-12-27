using System.ComponentModel;
using Caliburn.Micro;
using JetBrains.Annotations;
using LogoFX.Client.Mvvm.ViewModel.Services;

namespace LogoFX.Samples.Client.Presentation.Shell.ViewModels
{
    /// <summary>
    /// Root object of the application.
    /// </summary>
    [UsedImplicitly]    
    class ShellViewModel : Conductor<INotifyPropertyChanged>.Collection.OneActive
    {
        private readonly IViewModelCreatorService _viewModelCreatorService;

        public ShellViewModel(IViewModelCreatorService viewModelCreatorService)
        {
            _viewModelCreatorService = viewModelCreatorService;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            Items.Add(_viewModelCreatorService.CreateViewModel<SimpleEditorViewModel>());
        }
    }
}
