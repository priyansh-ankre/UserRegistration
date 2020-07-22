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



    }
}