using System.Threading.Tasks;
using FunPol.Contracts;

namespace FunPol.BusinessLayer.Interface
{
    /// <summary>
    /// Interface ICompanyService.
    /// </summary>
    public interface ICompanyService
    {
        /// <summary>
        /// Gets the company details.
        /// </summary>
        /// <returns><Returns the company details.</returns>
        Task<CompanyDetail[]> GetCompanyDetails();
    }
}
