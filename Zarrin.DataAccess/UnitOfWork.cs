using System;
using Zarrin.DataAccess.Context;
using Zarrin.DataAccess.Repositories;

namespace Zarrin.DataAccess {
    public class UnitOfWork : IDisposable
    {
        private readonly ZPNContext _context;

        public UnitOfWork (ZPNContext context)
        {
            _context = context;
        }
        int Commit()
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