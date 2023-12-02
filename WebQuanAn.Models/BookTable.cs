using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanAn.Models
{
    public class BookTable
    {
        [Key]
        public int Id { get;set; }
        public string Name { get;set; } 
        public string Email { get;set; }
        public string PhoneNumber { get;set; }
        public DateTime ArrivalDatetime { get; set; }
        public int NumberOfPeople { get;set; }
        [NotMapped]
        public string ArrivalDate => ArrivalDatetime.ToString("MM/dd/yyyy");
        [NotMapped]
        public string ArrivalTime => ArrivalDatetime.ToString("hh:mm tt");
        public string Message { get;set; }
    }
}
