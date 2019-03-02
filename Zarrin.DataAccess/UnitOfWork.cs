using System;
using Zarrin.DataAccess.Context;
using Zarrin.DataAccess.Repositories;

namespace Zarrin.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly ZPNContext _context;

        public UnitOfWork(ZPNContext context, UserRepository userRepository)
        {
            _context = context;
            Users = userRepository;
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }
        public UserRepository Users { get; set; }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}