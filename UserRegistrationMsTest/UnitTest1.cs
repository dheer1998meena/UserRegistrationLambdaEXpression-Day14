// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblemUsingLambdaExpression_Day14;

namespace UserRegistrationMsTest
{
    [TestClass]
    public class UnitTest1
    {
        // To check for valid and invalid first names
        [TestMethod]
        [DataRow("dheer")]
        [DataRow("Dheer")]
        public void ValidateFirstName(string firstName)
        {
            string firstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            try
            {
                bool actual = ValidateDetails.IsValid(firstName, firstNamePattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception : Invalid details", e.Message);
            }
        }

        //  To check for valid and invalid  last name
        [TestMethod]
        [DataRow("singh")]
        [DataRow("Singh")]
        public void ValidateLastName(string lastName)
        {
            string lastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            try
            {
                bool actual = ValidateDetails.IsValid(lastName,lastNamePattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception : Invalid details", e.Message);
            }
        }

        // To check for valid and invalid email id
        [TestMethod]
        [DataRow("abc.ch@gmail.com")]
        [DataRow("abc.ch@gmail")]
        [DataRow("dheer-123@gmail.com")]
        public void ValidateEmail(string email)
        {
            string emailPattern = "^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
            try
            {
                bool actual = ValidateDetails.IsValid(email, emailPattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception : Invalid details", e.Message);
            }
        }

        //  To check for valid and invalid mobile number
        [TestMethod]
        [DataRow("12 1234567890")]
        [DataRow("11234567890")]
        public void ValidateMobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = "^[0-9]{2}[ ][0-9]{10}$";
            try
            {
                bool actual = ValidateDetails.IsValid(mobileNumber, mobileNumberPattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception : Invalid details", e.Message);
            }
        }

        //  To check for valid and invalid password
        [TestMethod]
        [DataRow("Dheer@123")]
        [DataRow("dheer123")]
        public void ValidatePassword(string password)
        {
            string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            try
            {
                bool actual = ValidateDetails.IsValid(password, passwordPattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception : Invalid details", e.Message);
            }
        }



    }
}
