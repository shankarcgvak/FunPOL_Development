using FunPol.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunPol.Repository.Interface
{
    public interface IUserRepository
    {
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns><Returns the users.</returns>
        Task<UserDetails[]> GetUsers();
    }
}
