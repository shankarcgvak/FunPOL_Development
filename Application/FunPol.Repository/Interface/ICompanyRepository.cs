using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunPol.Contracts;

namespace FunPol.Repository.Interface
{
    /// <summary>
    /// Interface ICompanyRepository.
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Gets the company details.
        /// </summary>
        /// <returns><Returns the company details.</returns>
        Task<CompanyDetail[]> GetCompanyDetails();
    }
}
