using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentAHousband.Models;
using System.ComponentModel.DataAnnotations;

namespace RentAHousband.ViewModels
{
    public class NewHousbandViewModel
    {
        public IEnumerable<PersonalityType> PersonalityTypes { get; set; }

        public int? Id { get; set; }

        [Required]
        public string SkillName { get; set; }

        [Required]
        [Range(25, 63)]
        public int? Age { get; set; }

        [Required]
        public string Name { get; set; }


        public bool IsBearded { get; set; }

        [Display(Name = "Type of personality")]
        public int? PersonalityTypeId { get; set; }

        public NewHousbandViewModel()
        {
            Id = 0;
        }

        public NewHousbandViewModel(Housband housband)
        {
            Id = housband.Id;
            Name = housband.Name;
            SkillName = housband.SkillName;
            Age = housband.Age;
            IsBearded = housband.IsBearded;
            PersonalityTypeId = housband.PersonalityTypeId;
        }
    }
}