using Framework;
using Microsoft.Playwright;

namespace FrameworkPw
{
    internal class Common : ICommon<IElementHandle>
    {
        public static void OpenPage(string url)
        {
            Utilities<IResponse>.AwaitVoid(Driver.GetDriver().GotoAsync(url));
        }

        public static IElementHandle GetElement(string locator)
        {
            return Utilities<IElementHandle>.Await(Driver.GetDriver().WaitForSelectorAsync(locator));
        }

        public static void Click(string locator)
        {
            Utilities<IElementHandle>.AwaitVoid(GetElement(locator).ClickAsync());
        }

        public static void SendKeys(string locator, string keys)
        {
            Utilities<IElementHandle>.AwaitVoid(GetElement(locator).IsEditableAsync());
            Utilities<IElementHandle>.AwaitVoid(GetElement(locator).TypeAsync(keys));
        }
    }
}
