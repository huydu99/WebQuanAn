using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanAn.Models.ViewModels
{
    public class BookTableVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfPeople { get; set; }
        [Required]
        public string ArrivalDate { get; set; }
        [Required]
        public string ArrivalTime { get; set; }
        public string Message { get; set; }
    }
}
