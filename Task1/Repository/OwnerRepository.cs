using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.IRepository;
using Task1.Models;

namespace Task1.Repository
{
    public class OwnerRepository : Repository<Owner>, IOwnerRepository

    {
        public OwnerRepository(DbTaskOne context) : base(context)
        {

        }
        public DbTaskOne UserContext => Context as DbTaskOne;

    }
}
