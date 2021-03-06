﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneNumberValidator.Test
{
    [TestClass()]
    public class ValidatorTests
    {
        private Validator _validator;

        [TestInitialize]
        public void Init()
        {
            _validator = new Validator();
        }

        [TestMethod]
        public void TestNumbersOnly()
        {
            var isValid = _validator.IsNumberValid("123456");
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestNumberWithHyphens()
        {
            var isValid = _validator.IsNumberValid("123-456");
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestNumberWithLeadingPlus()
        {
            var isValid = _validator.IsNumberValid("+123-456");
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInvalidPhoneNumberWithLetters()
        {
            var isValid = _validator.IsNumberValid("26b");
            Assert.IsFalse(isValid);
        }
    }
}