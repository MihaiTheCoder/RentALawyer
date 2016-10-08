using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentALawyerWebApp.Models
{
    public class Lawyer
    {
        [JsonIgnore]
        public int ID { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<CategoryLawyer> Categories { get; set; }

        public virtual ICollection<LanguageLawyer> Languages { get; set; }

        public virtual ICollection<CountryLawyer> Countries { get; set; }
    }

    public class CountryLawyer
    {
        public int Id { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }
    }

    public class LanguageLawyer
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }
    }

    public class CategoryLawyer
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public int LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }

    }
}
