namespace FrameworkSe.Pages
{
    public class Google
    {
        public static void Open()
        {
            Common.OpenPage("https://www.google.com");
        }

        public static void RejectCookies()
        {
            string locator = "//*[@id='W0wltc']";
            Common.Click(locator);
        }

        public static void Search(string query)
        {
            string locator = "//*[@id='APjFqb']";
            Common.SendKeys(locator, query);
        }

        public static void ClickImFeelingLucky()
        {
            string locator = "(//*[@name='btnI'])[2]";
            Common.Click(locator);
        }
    }
}
