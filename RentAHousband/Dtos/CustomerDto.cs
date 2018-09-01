﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using RentAHousband.Models;

namespace RentAHousband.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]  //data annotations
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public int MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //      [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}