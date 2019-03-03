using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Zarrin.DataAccess.Context;
using Zarrin.Models.Entities;

namespace Zarrin.DataAccess.Repositories
{
    public class UserRepository : Repository<User>
    {
        public ZPNContext ZPNContext
        {
            get { return Context as ZPNContext; }
        }
        public UserRepository(ZPNContext context) : base(context)
        {
        }
        public IEnumerable<User> GetAllUsers(int pageIndex = 1, int pageSize = 10)
        {
            return GetAll().Skip(--pageIndex * pageSize).Take(pageSize).ToList();
        }
    }
}