using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Innovecs.API.Model.Request;
using Innovecs.Domain.Model;

namespace Innovecs.API.Services.Contracts
{
    public interface ICompanyService
    {
        Task<double> GetTotalAsync(CompanyTotalRequest companyTotalRequest);

        Task<double> GetAmountAsync(CompanyAmountRequest companyAmountRequest);

        Task<double> GetQuoteAsync(CompanyQuoteRequest companyQuoteRequest);
    }
}

