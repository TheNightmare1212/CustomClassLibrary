using System;
using CustomClassLibrary;
using Xunit;

namespace CustomClassLibrary.Tests
{
    public class AddressTest
    {
        [Fact]
        public void ShouldBeAbleToAddAddress()
        {
            Address address = new Address("Ocean Drive", "187", AddrType.Shipping, "Miami", "765456", "Florida", "USA");
            Assert.Equal("Ocean Drive", address.Line);
            Assert.Equal("187", address.Line2);
            Assert.Equal(AddrType.Shipping, address.Type);
            Assert.Equal("Miami", address.City);
            Assert.Equal("765456", address.PostalCode);
            Assert.Equal("Florida", address.State);
            Assert.Equal("USA", address.Country);

        }
    }
}
