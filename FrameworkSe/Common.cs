using Framework;

namespace FrameworkSe
{
    internal class Common : ICommon
    {
        public static void OpenPage(string url)
        {
            Driver.GetDriver().Url = url;
        }
    }
}
