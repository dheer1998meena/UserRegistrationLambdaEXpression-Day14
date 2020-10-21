// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblemUsingLambdaExpression_Day14
{
    public class CustomException : ApplicationException
    {
        public enum ExceptionType
        {
            INVALID_DETAILS
        }
        private readonly ExceptionType type;
        public CustomException (ExceptionType type , string message):base(message)
        {
            this.type = type;
        }

    }
}
