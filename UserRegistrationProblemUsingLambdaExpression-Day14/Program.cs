// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace UserRegistrationProblemUsingLambdaExpression_Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining Variables
            string firstName, lastName, emailId, mobileNumber, password;
            //Iterating using while loop to take user first name.
            while(true)
            {
                Console.WriteLine("Enter the user first name :");
                firstName = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the first letter of the name must be Capital
                bool valid = ValidateDetails.Validate(firstName, "^[A-Z][a-z]{2,}$");
                  //If the boolean returns false then displaying Invalid input otherwise storing the name into the variable firstName
                if (!valid)
                {
                    Console.WriteLine(" Invalid first name");
                }
                else
                {
                    break;
                }
                    
            }
            //Iterating using while loop to take user last name.
            while (true)
            {
                Console.WriteLine("Enter the user last name :");
                lastName = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the first letter of the name must be Capital
                bool valid = ValidateDetails.Validate(lastName, "^[A-Z][a-z]{2,}$");

                if(!valid)
                {
                    Console.WriteLine(" Invalid last name");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take user email.
            while (true)
            {
                Console.WriteLine("Enter the user Email :");
                emailId = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the email id must be in the correct form.

                bool valid = ValidateDetails.Validate(emailId, "^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$");

                if (!valid)
                {
                    Console.WriteLine(" Invalid Email");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take user mobile number.
            while (true)
            {
                Console.WriteLine("Enter the user mobile number:");
                mobileNumber = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the mobile number must be correct.
                bool valid = ValidateDetails.Validate(mobileNumber, "^[0-9]{2}[ ][0-9]{10}$");

                if (!valid)
                {
                    Console.WriteLine(" Invalid mobile number");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take user password.
            while (true)
            {
                Console.WriteLine("Enter the user password :");
                password = Console.ReadLine();

                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the password must be correct .
                bool valid = ValidateDetails.Validate(password, "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$");

                if (!valid)
                {
                    Console.WriteLine(" Invalid password");
                }
                else
                {
                    break;
                }
            }

            // Displaying all the details entered by the user.
            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + firstName + " " + lastName);
            Console.WriteLine("Email ID : " + emailId);
            Console.WriteLine("Mobile Number : " + mobileNumber);
        }
    }
}
