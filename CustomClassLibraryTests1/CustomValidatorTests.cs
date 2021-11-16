using System;
using System.Collections.Generic;
using System.Linq;
using CustomClassLibrary;
using Xunit;

namespace CustomClassLibrary.Tests
{
    public class CustomValidatorTests
    {
        [Fact]
        public void RequiredStringTest()
        {
            Customer customer = new Customer(
                null,
                null,
                null,
                null,
                null,
                0,
                null);
            var errors = CustomerValidator.Validate(customer);
            Assert.Equal("Поле LastName обязательно", errors[2]);
        }
        [Fact]
        public void MaxCharsTest()
        {
            Customer customer = new Customer(
                "Too much chars Too much chars Too much chars Too much chars Too much chars",
                "Too much chars Too much chars Too much chars Too much chars Too much chars",
                null,
                null,
                null,
                0,
                null
                );
            var errors = CustomerValidator.Validate(customer);
            Assert.Contains("Поле FirstName превышает возможную длину ", errors);
        }
        [Fact]
        public void EmailTest()
        {
            Customer customer = new Customer("Valeria", "Berezikova","+79059810854", "something", null, 0, null);
            var errors = CustomerValidator.Validate(customer);
            Assert.Equal("The Email field is not a valid e-mail address.", errors[0]);
        }
        [Fact]
        public void PhoneTest()
        {
            Customer customer = new Customer("Valeria", "Berezikova", "something", "degirl450@gmail.com", null, 0, null);
            var errors = CustomerValidator.Validate(customer);
            Assert.Equal("The Phone field is not a valid phone number.", errors[0]);
        }
        [Fact]
        public void ListTest()
        {
            Customer customer = new Customer(
                "Valeria",
                "Berezikova",
                null,
                null,
                null,
                0,
                null
                );
            var errors = CustomerValidator.Validate(customer);
            Assert.Contains("Список Notes не должен быть пустым ", errors);
        }

    }
}
