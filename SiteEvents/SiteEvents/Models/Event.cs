using SiteEvents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RequestWorkflow.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Event Name")]
        public string EventName { get; set; }

        [Required]
        [DisplayName("Location")]
        public string Location { get; set; }

        [Required]
        [DisplayName("Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        public virtual List<Comment> Comments { get; set; }

    }
}