using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.IRepository;
using Task1.Models;
using Task1.Repository;

namespace Task1
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbTaskOne _context;

        public IOwnerRepository Owners { get; private set; }
        public IPropertyRepository Properties { get; private set; }

        public UnitOfWork(DbTaskOne context)
        {
            _context = context;
            Owners = new OwnerRepository(_context);
            Properties = new PropertyRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

    }
}
