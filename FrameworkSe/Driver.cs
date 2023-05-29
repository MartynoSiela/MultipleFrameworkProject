using Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrameworkSe
{
    public class Driver : IDriver<IWebDriver>
    {
        static IWebDriver driver;

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
