using NUnit.Framework;

namespace UserRegistrationApp
{
    public class UserRegistrationTest
    {
        
        [Test]
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validFirstName("Priyansh");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenFirstName_WhenNotProper_ShouldReturnFalse()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validFirstName("priyansh");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenLasttName_WhenProper_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validLastName("Ankre");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenLastName_WhenNotProper_ShouldReturnFalse()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validLastName("ankre");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenProper_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProperWithOptionPart_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc-100@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc123@.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenMobileNo_WhenProper_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateMobileNo("91 4456830064");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenPassword_WhenProperForLengthUpperCaseNumericValueSpecialCharacter_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validatePassword("abcdE$fgh9");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenPassword_WhenNotProperForLength_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validatePassword("dcGv4");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenPassword_WhenNotProperForUpperCase_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validatePassword("dcgv4abce");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenPassword_WhenNotProperForNumericValue_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validatePassword("dcgvWabce");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenProper1_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper2_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc-100@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper3_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc.100@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper4_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc111@yahoo.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper5_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc.100@abc.com.au");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper6_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@1.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper7_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@gmail.com.co");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenProper8_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc+100@gmail.com");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper1_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper2_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@.com.my");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper3_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc123@gmail.a");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper4_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc123@.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper5_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc123@.com.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper6_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail(".abc@abc.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper7_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc()*@gmail.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper8_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@%*.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper9_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc..2002@gmail.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper10_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc.@gmail.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper11_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@abc@gmail.com");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper12_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@gmail.com.1a");
            Assert.IsFalse(isValid);
        }
        [Test]
        public void givenEmail_WhenNotProper13_ShouldReturnTrue()
        {
            UserRegistration user = new UserRegistration();
            bool isValid = user.validateEmail("abc@gmail.com.aa.au");
            Assert.IsFalse(isValid);
        }
    }
}