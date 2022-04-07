using InterestRate.Controllers;
using Main.Models;

using Xunit;

namespace InterestRate.Test
{
    public class RateControllerTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var controller = new RateController();
            CreditAmountInputModel creditAmountInputModel = new CreditAmountInputModel();
            creditAmountInputModel.creditAmount = "1999";
            var data = controller.Post(creditAmountInputModel);
            Assert.Equal("No", data.Decision);
        }
        [Fact]
        public void Test3()
        {
            var controller = new RateController();
            CreditAmountInputModel creditAmountInputModel = new CreditAmountInputModel();
            creditAmountInputModel.creditAmount = "2001";
            var data = controller.Post(creditAmountInputModel);
            Assert.Equal("Yes", data.Decision);
        }
        [Fact]
        public void Test4()
        {
            var controller = new RateController();
            CreditAmountInputModel creditAmountInputModel = new CreditAmountInputModel();
            creditAmountInputModel.creditAmount = "10000";
            var data = controller.Post(creditAmountInputModel);
            Assert.Equal(3, data.InterestPercentage);
        }
        [Fact]
        public void Test5()
        {
            var controller = new RateController();
            CreditAmountInputModel creditAmountInputModel = new CreditAmountInputModel();
            creditAmountInputModel.creditAmount = "20001";
            var data = controller.Post(creditAmountInputModel);
            Assert.Equal(4, data.InterestPercentage);
        }
        [Fact]
        public void Test6()
        {
            var controller = new RateController();
            CreditAmountInputModel creditAmountInputModel = new CreditAmountInputModel();
            creditAmountInputModel.creditAmount = "40000";
            var data = controller.Post(creditAmountInputModel);
            Assert.Equal(5, data.InterestPercentage);
        }
        [Fact]
        public void Test7()
        {
            var controller = new RateController();
            CreditAmountInputModel creditAmountInputModel = new CreditAmountInputModel();
            creditAmountInputModel.creditAmount = "60000";
            var data = controller.Post(creditAmountInputModel);
            Assert.Equal(6, data.InterestPercentage);
        }
    }
}
