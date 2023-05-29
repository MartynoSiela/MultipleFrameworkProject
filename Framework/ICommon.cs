namespace Framework
{
    public interface ICommon<T>
    {
        public static abstract void OpenPage(string url);
        public static abstract T GetElement(string locator);
        public static abstract void Click(string locator);
        public static abstract void SendKeys(string locator, string keys);
    }
}
