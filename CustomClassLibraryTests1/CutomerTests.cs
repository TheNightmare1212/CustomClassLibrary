using CustomClassLibrary;
using Xunit;

namespace CustomClassLibrary.Tests
{

    public class CutomerTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            Customer customer = new Customer("Valeria", "Berezikova", "+79085660987", "degirl450@gmail.com", null, 1100, null);
            Assert.Equal("Valeria", customer.FirstName);
            Assert.Equal("Berezikova", customer.LastName);
            Assert.Equal("+79085660987", customer.Phone);
            Assert.Equal("degirl450@gmail.com", customer.Email);
            Assert.Equal(1100, customer.TotalPurchaseAmount);
            Assert.Null(customer.Notes);
            Assert.Null(customer.Addresses);

           
        }

        
    }
}