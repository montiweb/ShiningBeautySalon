﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.Domain.Entities
{
    public class ServiceCategory
    {
        public int ID { get; set; }
        public int SalonID { get; set; }
        public string Title { get; set; }
    }
}
