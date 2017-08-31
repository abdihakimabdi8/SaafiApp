using SaafiApp.Core.Contracts.Services;
using Plugin.Connectivity;

namespace SaafiApp.Core.Services.General
{
    public class ConnectionService : IConnectionService
    {
        public bool CheckOnline()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
