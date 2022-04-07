using InterestRate.Models;

namespace InterestRates.Data.Interfaces
{
    public interface IinterestRateRepository
    {
        InterestDetailsModel GetInterestDetail(double creditAmount);
    }
}
