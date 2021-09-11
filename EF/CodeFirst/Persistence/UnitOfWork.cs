using CodeFirst.Core;
using CodeFirst.Core.Repository;
using CodeFirst.Models;
using CodeFirst.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserManagementContext _context;

        public UnitOfWork(UserManagementContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
