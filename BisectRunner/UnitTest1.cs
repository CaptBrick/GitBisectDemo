using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneNumberValidator;

namespace BisectUnitTest
{

	//this must be outside versino control
    [TestClass]
    public class UnitTest1
    {
        private Validator _validator;

        [TestInitialize]
        public void Init()
        {
            _validator = new Validator();
        }

        [TestMethod]
        public void TestPhoneNumberWithPlusInMiddle()
        {
            var isValid = _validator.IsNumberValid("123+123");
            Assert.IsFalse(isValid);
        }
    }
}