using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunPol.UnitOfWork.Interface;
using FunPol.UnitOfWork.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunPol.Mvc.Area.Company.Controllers
{
    /// <summary>
    /// Class CompanyController.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Area("Company")]
    public class CompanyController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyController"/> class.
        /// </summary>
        /// <param name="unitOfWork">The user of work.</param>
        public CompanyController(IUnitOfWork unitOfWork)
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
        /// Companies the details.
        /// </summary>
        /// <returns>Returns the company details</returns>
        public async Task<IActionResult> CompanyDetails()
        {
            CompanyViewModel[] userViewModel = await this.UnitOfWork.GetCompanyDetails();
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
