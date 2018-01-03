using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace mvc.Models
{
    public class Seat
    {
        public string Location
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }
    }
}
