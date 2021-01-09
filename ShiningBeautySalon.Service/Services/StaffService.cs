using ShiningBeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiningBeautySalon.Service.Services
{
    public class StaffService
    {
        List<Salon> Salons = new List<Salon> {
        new Salon { ID=1, Name="Monti Salon1", Address ="17 Barberry", Phone="4168245637", About="About Monti1", Slogan="Slogan Monti1", Logo="Monti Logo1", Url="MontiWebSolution.com"},
        new Salon { ID=2, Name="Monti Salon2", Address ="27 Barberry", Phone="4168333333", About="About Monti2", Slogan="Slogan Monti2", Logo="Monti Logo2", Url="MontiWebSolution.com"}
        };

        public IList<Salon> GetAll()
        {
            return Salons;
        }
    }
}
