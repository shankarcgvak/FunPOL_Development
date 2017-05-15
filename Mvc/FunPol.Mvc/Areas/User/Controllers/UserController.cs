using System.Threading.Tasks;
using FunPol.UnitOfWork.Interface;
using FunPol.UnitOfWork.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunPol.Mvc.Area.User.Controllers
{
    /// <summary>
    /// Class UserController.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Area("User")]
    public class UserController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="unitOfWork">The user of work.</param>
        public UserController(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        #region PrivateProperties
        /// <summary>
        /// The unit of work
        /// </summary>
        private readonly IUnitOfWork UnitOfWork;
        #endregion

        #region PublicMethods
        /// <summary>
        /// Users the details.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> UserDetails()
        {
            UserViewModel[] userViewModel = await this.UnitOfWork.GetUserDetails();
            return View(userViewModel);
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Error()
        {
            return View();
        }
        #endregion
    }
}
