using FrameworkPw;
using FrameworkPw.Pages;
using NUnit.Framework;

namespace TestsPw
{
    internal class GoogleTests
    {
        [Test]
        public void Demo()
        {
            Driver.SetupDriver();
            Google.Open();
            Google.RejectCookies();
            Google.Search("Hello World");
            Google.ClickImFeelingLucky();
            Driver.QuitDriver();
        }
    }
}
