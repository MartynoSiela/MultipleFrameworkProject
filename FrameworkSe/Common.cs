using Framework;
using OpenQA.Selenium;

namespace FrameworkSe
{
    internal class Common : ICommon<IWebElement>
    {
        public static void OpenPage(string url)
        {
            Driver.GetDriver().Url = url;
        }

        public static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        public static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        public static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }
    }
}
