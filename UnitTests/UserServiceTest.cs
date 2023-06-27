using NUnit.Framework;
using WebApp.Models;
using WebApp.Services;

namespace UnitTests
{
    public class UserServiceTest
    {
        UserService userService;

        [SetUp]
        public void SetUp()
        {
            userService = new UserService();
        }

        [Test]
        public void FilterUserByFirstName_Works()
        {
            // Arrange
            var name = "John";
            var users = new List<User>()
            {
                new User() {FirstName = "John", LastName = "Doe"},
                new User() {FirstName = "Jane", LastName = "Doe"},
                new User() {FirstName = "Yui", LastName = "Kimura"},
            };

            // Act
            var filteredUsers = userService.FilterUserByFirstName(name, users);

            // Assert
            Assert.That(filteredUsers, Is.EqualTo(users.Where(x => x.FirstName == name).ToList()));
            Assert.That(filteredUsers, Is.Not.Null);
        }
    }
}