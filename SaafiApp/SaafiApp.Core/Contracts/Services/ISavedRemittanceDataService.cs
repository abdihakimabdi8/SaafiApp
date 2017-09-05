using System.Collections.Generic;
using System.Threading.Tasks;
using SaafiApp.Core.Model;

namespace SaafiApp.Core.Contracts.Services
{
    public interface ISavedRemittanceDataService
    {
        Task<IEnumerable<SavedRemittance>> GetSavedRemittanceForUser(int userId);

        Task AddSavedRemittance(int userId, int remittanceId, int beneficiaryId);
    }
}

