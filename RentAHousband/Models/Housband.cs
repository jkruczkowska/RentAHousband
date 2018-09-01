using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentAHousband.Models
{
    public class Housband
    {
        public int Id { get; set; }

        [Required]
        public string SkillName { get; set; }

        [Required]
        [Range(25, 63)]
        public int Age { get; set; }

        [Required]
        public string Name { get; set; }


        public bool IsBearded { get; set; }

        [Display(Name = "Type of personality")]
        public PersonalityType PersonalityType { get; set; }

        public int PersonalityTypeId { get; set; }
    }

 //   /housband/show


}