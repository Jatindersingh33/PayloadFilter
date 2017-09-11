using PayloadFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PayloadFilter.ViewModels
{
    [JsonObject]
    public class PayloadViewModel
    {
        [JsonProperty]
        public string Image { get; set; }
        [JsonProperty]
        public string Slug { get; set; }
        [JsonProperty]
        public string Title { get; set; }
    }
}
