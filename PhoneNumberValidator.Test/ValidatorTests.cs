using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}