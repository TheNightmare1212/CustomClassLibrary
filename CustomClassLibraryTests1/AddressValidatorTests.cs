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
                "Canada"
                );
            AddressValidator validator = new();
            var errors = validator.ValidatorRun(addres);
            List<string> expected = new List<string>
            {
                "Поле не должно быть пустым!",
                "Поле не должно быть пустым!",
                "Поле не должно быть пустым!",
                "Поле не должно быть пустым!",
            };
            Assert.Equal(expected, errors);
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
            AddressValidator validator = new();
            var errors = validator.ValidatorRun(address);
            List<string> expected = new List<string>
            {
                "Поле превышает возможную длину",
                "Поле превышает возможную длину",
                "Поле превышает возможную длину",
                "Поле превышает возможную длину",
            };
            Assert.Equal(expected, errors);
        }


    }
}
