using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TicketingSystem.Models
{
    public class Response
    {
        [Key]
        public int ID { get; set; }
        public int TicketID { get; set; }
        public string Solution { get; set; }
        public string Remarks { get; set; }
    }
}