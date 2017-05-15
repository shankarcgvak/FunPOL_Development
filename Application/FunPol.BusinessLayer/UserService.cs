using System.Collections.Generic;
using FunPol.BusinessLayer.Interface;
using FunPol.Contracts;
using FunPol.Repository.Interface;
using System.Threading.Tasks;

namespace FunPol.BusinessLayer
{
    /// <summary>
    /// Class UserService.
    /// </summary>
    /// <seealso cref="FunPol.BusinessLayer.Interface.IUserService" />
    public class UserService : IUserService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="userRepository">The user repository.</param>
        public UserService(IUserRepository userRepository)
        {
            this.UserRepository = userRepository;
        }

        #region PrivateProperties
        /// <summary>
        /// The User repository
        /// </summary>
        private IUserRepository UserRepository;
        #endregion

        #region PublicMethods 
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns></returns>
        public async Task<UserDetails[]> GetUsers()
        {
            return await this.UserRepository.GetUsers();
        }
        #endregion
    }
}
