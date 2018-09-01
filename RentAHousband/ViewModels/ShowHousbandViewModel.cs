using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentAHousband.Models;

namespace RentAHousband.ViewModels
{
    public class ShowHousbandViewModel
    {
        public Housband Housband { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Housband> Housbands { get; set; }

    }
}