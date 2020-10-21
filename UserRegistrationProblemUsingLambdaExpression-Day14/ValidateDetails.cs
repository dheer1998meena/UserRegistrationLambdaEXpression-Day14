// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemUsingLambdaExpression_Day14
{
     public class ValidateDetails
    {
        //UC13  Refactor to use Lambda Exp to validate user details

        //Creating a Lambda Expression to validate the details entered by the user by matching the entry with the corresponding Regular Expression
        //Lambda function  validate declared which returns true if valid entry otherwise false.
        public static Func<string, string, bool> Validate = (userEntry, Pattern) => Regex.IsMatch(userEntry, Pattern);
        //creating a method to validate the entered user data with the corresponding Regular Expression
        public static bool IsValid(string userEntry, string Pattern)
        {
            //if matches then returns true
            if (Validate(userEntry, Pattern))
                return true;
            //else throw custom exception 
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_DETAILS, "Exception : Invalid details");
            }
        }
    }
}
