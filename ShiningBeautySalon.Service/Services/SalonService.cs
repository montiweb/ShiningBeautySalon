using Microsoft.EntityFrameworkCore;
using ShiningBeautySalon.DAL.Context;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningBeautySalon.Service.Services
{
    public class SalonService : ISalonService
    {
        private readonly ShiningContext _context;

        public SalonService(ShiningContext ctx)
        {
            _context = ctx;
        }

        public IList<Salon> Salons;

        public IList<Salon> Get()
        {
            Salons = _context.Salons.ToList();
            return Salons;
        }
    }
}
