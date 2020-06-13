using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.IRepository
{
   public interface IUnitOfWork: IDisposable
    {
        IOwnerRepository Owners { get; }
        IPropertyRepository Properties { get; }
        int Complete();

    }
}
