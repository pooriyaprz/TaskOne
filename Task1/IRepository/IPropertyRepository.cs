using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.IRepository
{
   public interface IPropertyRepository : IRepository<Property>
    {
        Task<IEnumerable<Property>> GetAllByDetails();
    }
}
