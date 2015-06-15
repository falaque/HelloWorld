using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker
    {
        public Int32 SpeakerId { get; set; }

        [Required(ErrorMessage= "{0} is required")]
        [Display(Name = "Speaker")]
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }

        //public virtual List<Session> Sessions { get; set; }
    }
}
