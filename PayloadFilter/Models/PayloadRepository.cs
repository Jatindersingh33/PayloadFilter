using Microsoft.Extensions.Logging;
using PayloadFilter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayloadFilter.Models
{
    public class PayloadRepository : IPayloadRepository
    {
        public IEnumerable<PayloadViewModel> GetFilteredPayload(Payloads payloads)
        {
            var eligiblePayloads = payloads.Payload
                .Where(x => x.EpisodeCount > 0 && x.Drm == true)
                .Select(y => y).ToList();

            return  (from payload in eligiblePayloads
                    select new PayloadViewModel()
                    {
                        Image = payload.Image.ShowImage,
                        Slug = payload.Slug,
                        Title = payload.Title
                    }).ToList();
        }
    }
}
