using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWE5201_AssingmentV3;

namespace App.Tests
{
    [TestFixture]
    public class AuthenticationTests
    {
        [TestCase("MQZak", "abcd1234", ExpectedResult = true)]
        [TestCase("invalidUser", "invalidPassword", ExpectedResult = false)]
        public bool AuthenticateUser_WithValidCredentials_ReturnsExpectedResult(string username, string password)
        {
            bool isAuthenticated = false;

            Thread thread = new Thread(() =>
            {
                // Arrange
                Login authentication = new Login(null);

                // Act
                isAuthenticated = authentication.AuthenticateUser(username, password);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            // Assert
            return isAuthenticated;
        }

        [TestCase("", "abcd1234")]
        [TestCase("MQZak", "")]
        [TestCase("", "")]

        public void AuthenticateUser_WithEmptyCredentials_ReturnsFalse(string username, string password)
        {
            bool isAuthenticated = false;

            Thread thread = new Thread(() =>
            {
                // Arrange
                Login authentication = new Login(null);

                // Act
                isAuthenticated = authentication.AuthenticateUser(username, password);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            // Assert
            Assert.IsFalse(isAuthenticated);
        }
    }
}
