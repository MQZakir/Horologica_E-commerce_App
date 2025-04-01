using SWE5201_AssingmentV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Moq;

namespace App.Tests
{
    public class RegisterTests
    {
        // Initial tests without using mocks.

        public void Rand()
        {
            Console.WriteLine("Hi");
        }

        [TestCase("garryG", "abcd1234", "abcd1234", ExpectedResult = true)]
        public bool ValidateInputs_WhenCalled_ReturnsExpectedResult(string username, string password, string confirmPassword)
        {
            bool result = false;
            Thread thread = new Thread(() =>
            {
                // Arrange
                var registration = new Login(null);

                //Act
                result = registration.ValidateInputs(username, password, confirmPassword);
            });
            thread.SetApartmentState(ApartmentState.STA); // Set thread apartment state to STA
            thread.Start();
            thread.Join(); // Wait for the thread to finish

            // Assert
            return result;
        }

        // Below tests that username validity, if an existing username is provided it should return false, else it should return true
        [TestCase("MQZak", ExpectedResult = false)] // Existing username (On purpose true to make sure this test fails)
        [TestCase("fredd", ExpectedResult = true)] // New username
        public bool CheckUsernameUnique_WhenCalled_ReturnsExpectedResult(string username)
        {
            bool result = false;

            Thread thread = new Thread(() =>
            {
                // Arrange
                var registration = new Login(null);

                // Act
                result = registration.CheckUsernameUnique(username);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            // Assert
            return result;
        }

        // The test below checks if the input city is valid or not
        [TestCase("dubai", ExpectedResult = true)] // valid input, returns true (should pass)
        [TestCase("abu dhabi", ExpectedResult = true)] // valid input, returns true (should pass)
        [TestCase("sharjah", ExpectedResult = true)] // valid input, returns true (should pass)
        [TestCase("london", ExpectedResult = false)] // invalid input, returns false (should pass)
        public bool ValidateCity_WhenCalled_ReturnsExpectedResult(string city)
        {
            bool result = false;

            Thread thread = new Thread(() =>
            {
                // Arrange
                var registration = new Login(null);

                // Act
                result = registration.ValidateCity(city);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            // Assert
            return result;
        }
    }
}
