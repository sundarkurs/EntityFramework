using CodeFirst.Core.Repository;
using System;

namespace CodeFirst.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}
