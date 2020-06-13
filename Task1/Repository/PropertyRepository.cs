using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.IRepository;
using Task1.Models;

namespace Task1.Repository
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository

    {
        public PropertyRepository(DbTaskOne context) : base(context)
        {
        }

        public DbTaskOne DbTaskOneContext
        {
            get { return Context as DbTaskOne; }
        }

        public async Task<IEnumerable<Property>> GetAllByDetails()
        {
            return await DbTaskOneContext.Properties.Include(x => x.Owner).ToListAsync();
        }
    }
}
