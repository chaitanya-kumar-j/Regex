using NUnit.Framework;
using RegexPractice;
using System;
using System.IO;

namespace UserRegistrationTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstNameInCorrectFormat_WhenFirstNameValidation_ThenShouldReturnTrue()
        {
            string testFirstName = "Chaitanya";
            bool result = new UserRegistration().FirstNameValidation(testFirstName);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void GivenFirstNameInWrongFormat_WhenFirstNameValidation_ThenShouldReturnFalse()
        {
            string expextedException = "Entered firstname is not as per requirements";
            string testFirstName = "Ch";
            try
            {
                bool result = new UserRegistration().FirstNameValidation(testFirstName);
                Assert.AreEqual(false, result);
            }
            catch(CustomExceptions ex)
            {
                Assert.AreEqual(expextedException, ex.Message);
            }
        }
        [Test]
        public void GivenLastNameInCorrectFormat_WhenLastNameValidation_ThenShouldReturnTrue()
        {
            string testLastName = "Kumar";
            bool result = new UserRegistration().LastNameValidation(testLastName);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void GivenLastNameInWrongFormat_WhenLastNameValidation_ThenShouldReturnFalse()
        {
            string expectedException = "Entered lastname is not as per requirements";
            string testLastName = "kumar";
            try
            {
                bool result = new UserRegistration().LastNameValidation(testLastName);
                Assert.AreEqual(false, result);
            }
            catch(CustomExceptions ex)
            {
                Assert.AreEqual(expectedException, ex.Message);
            }
        }
        [Test]
        public void GivenEmailIdInCorrectFormat_WhenEmailValidation_ThenShouldReturnTrue()
        {
            string testEmail = "Chaitanya.Kumar@gmail.com";
            bool result = new UserRegistration().EmailValidation(testEmail);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void GivenEmailIdInWrongFormat_WhenEmailValidation_ThenShouldReturnFalse()
        {
            string expectedException = "Entered email is not as per requirements";
            string testEmail = "kumar@gmail.@.com";
            try
            {
                bool result = new UserRegistration().EmailValidation(testEmail);
                Assert.AreEqual(false, result);
            }
            catch(CustomExceptions ex)
            {
                Assert.AreEqual(expectedException, ex.Message);
            }
        }
        [Test]
        public void GivenMobileNumberInCorrectFormat_WhenMobileNumberValidation_ThenShouldReturnTrue()
        {
            string testMobileNumber = "91 8234567890";
            bool result = new UserRegistration().MobileNumberValidation(testMobileNumber);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void GivenMobileNumberInWrongFormat_WhenMobileNumberValidation_ThenShouldReturnFalse()
        {
            string expectedException = "Entered Mobile number is not as per requirements";
            string testMobileNumber = "91 1234567890";
            try
            {
                bool result = new UserRegistration().MobileNumberValidation(testMobileNumber);
                Assert.AreEqual(false, result);
            }
            catch(CustomExceptions ex)
            {
                Assert.AreEqual(expectedException, ex.Message);
            }
        }
        [Test]
        public void GivenPasswordInCorrectFormat_WhenPasswordValidation_ThenShouldReturnTrue()
        {
            string testPassword = "Abcd_123";
            bool result = new UserRegistration().PasswordValidation(testPassword);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void GivenPasswordInWrongFormat_WhenPasswordValidation_ThenShouldReturnFalse()
        {
            string expectedException = "Entered Password is not as per requirements";
            string testPassword = "Abcd_abcd";
            try
            {
                bool result = new UserRegistration().PasswordValidation(testPassword);
                Assert.AreEqual(false, result);
            }
            catch(CustomExceptions ex)
            {
                Assert.AreEqual(expectedException, ex.Message);
            }
        }
        string emailsFilePath = @"G:\BridgeLabz\Regex\RegexPractice\EmailsList.txt";
        [Test]
        public void GivenListOfEmailIdsInCorrectFormat_WhenEmailValidation_ThenShouldReturnTrueForEachTime()
        {
            string[] validEmailList = File.ReadAllLines(emailsFilePath)[0].Split(",");
            foreach (string testEmail in validEmailList)
            {
                
                bool result = new UserRegistration().EmailValidation(testEmail);
                Assert.AreEqual(true, result);
            }
        }
        [Test]
        public void GivenListOfEmailIdsInWrongFormat_WhenEmailValidation_ThenShouldReturnFalseForEachTime()
        {
            string expectedException = "Entered email is not as per requirements";
            string[] inValidEmailList = File.ReadAllLines(emailsFilePath)[1].Split(",");
            foreach (string testEmail in inValidEmailList)
            {
                try
                {
                    bool result = new UserRegistration().EmailValidation(testEmail);
                    Assert.AreEqual(false, result);
                }
                catch (CustomExceptions ex)
                {
                    Assert.AreEqual(expectedException, ex.Message);
                }
            }
        }
    }
}