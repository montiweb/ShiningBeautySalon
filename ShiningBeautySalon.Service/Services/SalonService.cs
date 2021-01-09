using Microsoft.EntityFrameworkCore;
using ShiningBeautySalon.DAL.Context;
using ShiningBeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningBeautySalon.Service.Services
{
    public class SalonService
    {
       // protected DbContextOptionsBuilder Builder { get; set; }
       // protected ShiningContext Context { get; set; }

        public SalonService()
        {
         //   Context = new ShiningContext();
        }

        public IList<Salon> Get()
        {
            using (var context =  new ShiningContext())
            {
                return context.Salons.ToList();
            }                
        }
    }
}
