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
            CustomerValidator validator = new();
            Customer customer = new Customer(
                null,
                null,
                null,
                null,
                null,
                0,
                null);
            var errors = validator.ValidatorRun(customer);
            List<string> expected = new List<string>
            {
                "Поле не должно быть пустым!",
                "Список не должен быть пустым!",
                "Список не должен быть пустым!"
            };
            Assert.Equal(expected, errors);
        }
        [Fact]
        public void MaxCharsTest()
        {
            CustomerValidator validator = new();
            Customer customer = new Customer(
                "Too much chars Too much chars Too much chars Too much chars Too much chars",
                "Too much chars Too much chars Too much chars Too much chars Too much chars",
                null,
                null,
                null,
                0,
                null
                );
            var errors = validator.ValidatorRun(customer);
            List<string> expected = new List<string>
            {
                "Поле превышает возможную длину",
                "Поле превышает возможную длину",
                "Список не должен быть пустым!",
                "Список не должен быть пустым!",
            };
            Assert.Equal(expected, errors);
        }
        [Fact]
        public void EmailTest()

        {
            CustomerValidator validator = new();
            Customer customer = new Customer("Valeria", "Berezikova", "+79059810854", "something", null, 0, null);
            var errors = validator.ValidatorRun(customer);
            List<string> expected = new List<string>
            {
                "Список не должен быть пустым!",
                "Список не должен быть пустым!",
                "Введите корректный адрес электронной почты"
            };
            Assert.Equal(expected, errors);
        }
        [Fact]
        public void PhoneTest()
        {
            CustomerValidator validator = new();
            Customer customer = new Customer("Valeria", "Berezikova", "something", "degirl450@gmail.com", null, 0, null);
            var errors = validator.ValidatorRun(customer);
            List<string> expected = new List<string>
            {
                "Список не должен быть пустым!",
                "Список не должен быть пустым!",
                "Введите корректный номер телефона"
            };
            Assert.Equal(expected, errors);
        }
        [Fact]
        public void ListTest()
        {
            CustomerValidator validator = new();
            Customer customer = new Customer(
            "Valeria",
            "Berezikova",
            null,
            null,
            null,
            0,
            null
            );
            var errors = validator.ValidatorRun(customer);
            List<string> expected = new List<string>
            {
                "Список не должен быть пустым!",
                "Список не должен быть пустым!"
            };
            Assert.Equal(expected, errors);
        }

    }
}
