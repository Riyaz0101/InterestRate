using InterestRate.Models;
using InterestRates.Data.Interfaces;

namespace InterestRates.Data.Repositories
{
    public class InterestRateRepository : IinterestRateRepository
    {
        public InterestDetailsModel GetInterestDetail(double creditAmount)
        {
            var minAmount = (double)2000;
            var maxAmount = (double)69000;

            InterestDetailsModel intDetailsModel = new InterestDetailsModel();

            string Decision = creditAmount <= minAmount ? "No" : creditAmount > maxAmount ? "No" : "Yes";
            intDetailsModel.Decision = Decision;
            intDetailsModel.CreditAmount = creditAmount;
            intDetailsModel.InterestPercentage = 0;

            if (Decision == "Yes")
            {
                if (creditAmount > minAmount && creditAmount < 20000)
                    intDetailsModel.InterestPercentage = 3;
                else if (creditAmount >= 20000 && creditAmount < 40000)
                    intDetailsModel.InterestPercentage = 4;
                else if (creditAmount >= 40000 && creditAmount < 60000)
                    intDetailsModel.InterestPercentage = 5;
                else if (creditAmount >= 60000)
                    intDetailsModel.InterestPercentage = 6;
            }

            return intDetailsModel;
        }
    }
}
