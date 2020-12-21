using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.Domain.Entities
{
    public class ServiceItem
    {
        public int ID { get; set; }
        public int ServiceCategoryID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
    }
}
