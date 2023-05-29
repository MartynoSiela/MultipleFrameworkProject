using FrameworkSe;
using FrameworkSe.Pages;
using NUnit.Framework;

namespace TestsSe
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
