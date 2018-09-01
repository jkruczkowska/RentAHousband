using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentAHousband.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public int SingUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
        public string MembershipTypeName { get; set; }

        public static int Unknown = 0;
        public static int PayAsYouGo = 1;

    }
}