using System;
namespace SoundPocket.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        public DiscoverViewModel()
        {
            SelectedViewModelIndex = 0;
        }

        private int selectedViewModelIndex;
        public int SelectedViewModelIndex
        {
            get { return selectedViewModelIndex; }
            set { SetProperty(ref selectedViewModelIndex, value); }
        }
    }
}
