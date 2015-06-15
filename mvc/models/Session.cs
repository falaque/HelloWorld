using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Session
    {
        public Int32 SessionId { get; set; }
        public String Title { get; set; }
        [Required()]
        [DataType(DataType.MultilineText)]
        public String Abstract { get; set; }
        public Int32 SpeakerId { get; set; }
        public virtual Speaker Speaker { get; set; }
    }
}
