using System;
using UsernameAndPassword;
using Xunit;

namespace UsernameAndPassword.Tests
{
    public class PasswordTests
    {
        [Fact]
        public void ReturnsPassword()
        {
            var newUser = CreateNewUser();
            newUser.Password = SetNewPassword("testing9");
            var expected = "testing9";
            Assert.Equal(expected, newUser.Password.password);
        }

        private BaseUserModel CreateNewUser()
        {
            var result = new BaseUserModel();
            return result;
        }

        private Password SetNewPassword(string password)
        {
            var result = new Password();
            result.SetPassword(password);
            return result;
        }
    }
}
