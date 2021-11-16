using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using CustomClassLibrary;

namespace CustomClassLibrary.Tests
{
    public class AddressValidatorTests
    {
        [Fact]
        public void RequiredTest()
        {
            Address addres = new Address
                (null,
                null,
                AddrType.Billing,
                null,
                null,
                null,
                null
                );
            var errors = AddressValidator.Validate(addres);
            Assert.True(errors.Count == 5);
        }
        [Fact]
        public void MaxCharsTest()
        {
            Address address = new Address(
                "Too much chars Too much chars Too much chars Too much chars Too much chars Too much chars Too much chars Too much chars",
                "Too much chars Too much chars Too much chars Too much chars Too much chars Too much chars Too much chars Too much chars",
                AddrType.Billing,
                "Too much chars Too much chars Too much chars Too much chars Too much chars ",
                "Too much chars",
                "Too much chars Too much chars ",
                "Canada"
                );
            var errors = AddressValidator.Validate(address);
            Assert.True(errors.Count == 5);
        }


    }
}
