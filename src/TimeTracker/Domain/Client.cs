using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Domain
{
    public class Client
    {

        public long id {get; set;}

        [Required]
        public string name { get; set; }

    
    }
}
