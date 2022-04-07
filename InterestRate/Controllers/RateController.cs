using InterestRate.Models;
using InterestRates.Data.Interfaces;
using InterestRates.Data.Repositories;
using Main.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InterestRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private IinterestRateRepository interestRateRepository = new InterestRateRepository();

       [HttpPost]
        public InterestDetailsModel Post([FromBody] CreditAmountInputModel obj)
        {
            var data = interestRateRepository.GetInterestDetail(Convert.ToDouble(obj.creditAmount));
            if (data == null)
            {
                return new InterestDetailsModel();
            }
            return data;
        }
    }
}
