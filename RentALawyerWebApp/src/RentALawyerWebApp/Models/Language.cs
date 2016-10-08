using Newtonsoft.Json;
using System.Collections.Generic;

namespace RentALawyerWebApp.Models
{
    public class Language
    {
        [JsonIgnore]
        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }        
    }
}