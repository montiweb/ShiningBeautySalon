using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShiningBeautySalon.Domain.Entities
{
    //[Table("Salons", Schema="dbo")]
    public class Salon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string About { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
    }
}
