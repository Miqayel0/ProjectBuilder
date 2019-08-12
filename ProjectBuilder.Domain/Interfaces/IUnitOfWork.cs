using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Complete();
    }
}
