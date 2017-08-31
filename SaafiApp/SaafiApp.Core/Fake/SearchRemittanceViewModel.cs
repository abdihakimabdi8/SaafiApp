using SaafiApp.Core.ViewModels;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;
using SaafiApp.Core.Contracts.Services;

namespace SaafiApp.Core.Fake
{
    public class FakeSearchRemittanceViewModel : SearchRemittanceViewModel
    {
        public FakeSearchRemittanceViewModel(IMvxMessenger messenger, ICityDataService cityDataService, IConnectionService connectionService, IDialogService dialogService) : base(messenger, cityDataService, connectionService, dialogService)
        {
        }

        public new Task InitializeAsync()
        {
            return base.InitializeAsync();
        }
    }
}
