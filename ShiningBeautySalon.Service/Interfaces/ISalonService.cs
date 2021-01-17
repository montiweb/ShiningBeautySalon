using ShiningBeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface ISalonService
    {
        IList<Salon> Get();
    }
}
