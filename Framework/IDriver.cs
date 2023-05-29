namespace Framework
{
    public interface IDriver<T>
    {
        public static abstract void SetupDriver();
        public static abstract T GetDriver();
        public static abstract void QuitDriver();
    }
}
