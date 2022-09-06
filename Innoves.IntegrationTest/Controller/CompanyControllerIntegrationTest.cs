using System;
using System.Threading.Tasks;
using Innovecs.API.Controllers;
using Innovecs.API.Model.Request;
using Innovecs.API.Services;
using Innovecs.API.Services.Contracts;
using Innovecs.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Innoves.IntegrationTest.Controller
{
    public class CompanyControllerIntegrationTest
    {
        private CompanyController companyController;
        private ICompanyService companyService;

        public CompanyControllerIntegrationTest()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ICompanyService, CompanyService>()
                .BuildServiceProvider();
            companyService = serviceProvider.GetService<ICompanyService>();
            companyController = new CompanyController(companyService);
        }

        [Fact]
        public async Task GetAmount()
        {
            var request = new CompanyAmountRequest()
            {
                Cartons = new string[] { "Carton1", "Carton2" },
                Consignee = "Mario",
                Consignor = "Alejandro"                
            };
            var result = await companyController.GetAmount(request);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (result as OkObjectResult).StatusCode);
        }

        [Fact]
        public async Task GetAmountNotFound()
        {
            var request = new CompanyAmountRequest()
            {
                Cartons = new string[] { "Carton5", "Carton6" },
                Consignee = "Mario",
                Consignor = "Alejandro"
            };
            var result = await companyController.GetAmount(request);
            Assert.IsType<NoContentResult>(result);
            Assert.Equal(204, (result as NoContentResult).StatusCode);
        }

        [Fact]
        public async Task GetQuote()
        {
            var request = new CompanyQuoteRequest()
            {
                Destination = "Destination1",
                Source = "SourceAddress1",
                Packages = new System.Collections.Generic.List<string>
                {
                    "Package1", "Package3"
                }
            };
            var result = await companyController.GetQuote(request);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (result as OkObjectResult).StatusCode);
        }

        [Fact]
        public async Task GetQuoteNotFound()
        {
            var request = new CompanyQuoteRequest()
            {
                Destination = "DestinationNotfound",
                Source = "Source",
                Packages = new System.Collections.Generic.List<string>
                {
                    "Package1", "Package3"
                }
            };
            var result = await companyController.GetQuote(request);
            Assert.IsType<NoContentResult>(result);
            Assert.Equal(204, (result as NoContentResult).StatusCode);
        }
    }
}

