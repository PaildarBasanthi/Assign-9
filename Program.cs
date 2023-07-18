using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter their name
                Console.WriteLine("Enter your name:");
                var name = Console.ReadLine();

                // Prompt the user to enter their email
                Console.WriteLine("Enter your email:");
                var email = Console.ReadLine();

                // Prompt the user to enter their password
                Console.WriteLine("Enter your password:");
                var password = Console.ReadLine();
                // Check for minimum length requirements
                if (name.Length < 6)
                {
                    throw new ValidationException("Name must have at least 6 characters.");
                }
                if (password.Length < 8)
                {
                    throw new ValidationException("Password must have at least 8 characters.");
                }

                // Validate the user input
                ValidateInput(name, email, password);

                // Registration successful
                Console.WriteLine("Registration successful!");
            }
            catch (ValidationException ex)
            {
                // Display the error message to the user
                Console.WriteLine("Registration failed. Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Display a generic error message for other exceptions
                Console.WriteLine("An error occurred. Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("validation Completed");
            }
        }
        public static void ValidateInput(string name, string email, string password)
        {
            // Check for missing or empty fields
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ValidationException("Name is required.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ValidationException("Email is required.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ValidationException("Password is required.");
            }

          

        }
    }
}
