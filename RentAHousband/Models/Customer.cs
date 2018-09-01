using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentAHousband.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]  //data annotations
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership type")]
        public int MembershipTypeId { get; set; }

        [Display(Name="Date of birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}