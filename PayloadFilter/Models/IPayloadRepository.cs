using PayloadFilter.Models;
using PayloadFilter.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PayloadFilter.Models
{
    public interface IPayloadRepository
    {
         IEnumerable<PayloadViewModel> GetFilteredPayload(Payloads payloads);

    }
}