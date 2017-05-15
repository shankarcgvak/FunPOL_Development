using System.Collections.Generic;
using FunPol.Contracts;
using System.Threading.Tasks;

namespace FunPol.BusinessLayer.Interface
{
    /// <summary>
    /// Interface IUserService.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns><Returns the users.</returns>
        Task<UserDetails[]> GetUsers();
    }
}
