using System;
using UsernameAndPassword;
using Xunit;

namespace UsernameAndPassword.Tests
{
    public class UsernameTests
    {
        [Fact]
        public void ReturnsUsername()
        {
            var newUser = CreateNewUser();
            newUser.Username = CreateUsername("ocanica");
            var expected = "ocanica";
            Assert.Equal(expected, newUser.Username.username);
        }

        private BaseUserModel CreateNewUser()
        {
            var result = new BaseUserModel();
            return result;
        }

        private Username CreateUsername(string username)
        {
            var result = new Username();
            result.SetUsername(username);
            return result;
        }
    }
}
