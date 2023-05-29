using Microsoft.Playwright;

namespace FrameworkPw
{
    internal class Common
    {
        internal static void OpenPage(string url)
        {
            Utilities<IResponse>.AwaitVoid(Driver.GetDriver().GotoAsync(url));
        }
    }
}
