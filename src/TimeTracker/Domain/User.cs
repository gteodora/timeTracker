﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Domain
{
    public class User
    {
        public long id { get; set;
        }

        [System.ComponentModel.DataAnnotations.Required]
        public string name { get; set; }

        public decimal HourRate { get; set; }


    }
}
