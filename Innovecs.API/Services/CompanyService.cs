using System;
using System.Linq;
using System.Threading.Tasks;
using Innovecs.API.Model.Request;
using Innovecs.API.Services.Contracts;

namespace Innovecs.API.Services
{
    public class CompanyService : ICompanyService
    {
        public Task<double> GetAmountAsync(CompanyAmountRequest companyAmountRequest)
        {
            var companies = Domain.Data.Company.Get().Where(data =>
                data.Consignee.Equals(companyAmountRequest.Consignee) &&
                data.Consignor.Equals(companyAmountRequest.Consignor));


            companies = companies.Where(data => data.Cartons.Select(item => item.Name).ToArray().Intersect(companyAmountRequest.Cartons).Count().Equals(companyAmountRequest.Cartons.Length) );

            if (companies != null && companies.Any())
            {
                return Task.FromResult(companies.Min(data => data.Amount));
            }
            throw new Exception("Not found");
        }

        public Task<double> GetQuoteAsync(CompanyQuoteRequest companyQuoteRequest)
        {
            var companies = Domain.Data.Company.Get().Where(data =>
                data.DestinationAddress.Equals(companyQuoteRequest.Destination) &&
                data.Packages.Select(item => item.Name).ToArray().Intersect(companyQuoteRequest.Packages).Count().Equals(companyQuoteRequest.Packages.Count()));

            if (companies != null && companies.Any())
            {
                return Task.FromResult(companies.Min(data => data.Price));
            }
            throw new Exception("Not found");
        }

        public Task<double> GetTotalAsync(CompanyTotalRequest companyTotalRequest)
        {
            var companies = Domain.Data.Company.Get().Where(data =>
                data.ContactAddress.Equals(companyTotalRequest.ContactAddress) &&
                data.WareHouseAddress.Equals(companyTotalRequest.WareHouseAddress) &&
                data.Packages.Any(package => companyTotalRequest.PackageDimensions.FirstOrDefault(dimension =>
                                dimension.Length.Equals(package.Dimension.Length) &&
                                dimension.Height.Equals(package.Dimension.Height) &&
                                dimension.Width.Equals(package.Dimension.Width)) != null));
            if (companies != null && companies.Any())
            {
                return Task.FromResult(companies.Min(data => data.Amount * data.Price));
            }
            throw new Exception("Not found");
        }
    }
}

