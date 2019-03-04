using System;
using System.Collections.Generic;
using System.Linq;
using Zarrin.DataAccess;
using Zarrin.Models.Entities;
using Zarrin.Services.DataTransferObjects;

namespace Zarrin.Services.Services
{
    public class AccountService
    {
        private readonly UnitOfWork _unitOfWork;
        public AccountService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            return _unitOfWork.Users.GetAll().Select(u => new UserDto {
                    Id = u.Id,
                    Username = u.Username,
                    Password = u.Password
            });
        }
    }
}