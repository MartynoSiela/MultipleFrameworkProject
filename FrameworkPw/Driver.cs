using Framework;
using Microsoft.Playwright;

namespace FrameworkPw
{
    public class Driver : IDriver<IPage>
    {
        static IPage page;
        static IBrowser browser;

        public static void SetupDriver()
        {
            BrowserTypeLaunchOptions options = new BrowserTypeLaunchOptions();
            options.Headless = false;

            IPlaywright playwright = Utilities<IPlaywright>.Await(Playwright.CreateAsync());
            browser = Utilities<IBrowser>.Await(playwright.Chromium.LaunchAsync(options));
            page = Utilities<IPage>.Await(browser.NewPageAsync());
        }

        public static IPage GetDriver()
        {
            return page;
        }

        public static void QuitDriver()
        {
            Utilities<IBrowser>.AwaitVoid(browser.CloseAsync());
        }
    }
}
