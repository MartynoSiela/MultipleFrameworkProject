namespace FrameworkPw
{
    internal class Utilities<T>
    {
        internal static T Await(Task<T> func)
        {
            return func.Result;
        }

        internal static void AwaitVoid(Task<T?> func)
        {
            T? result = func.Result;
        }

        internal static void AwaitVoid(Task func)
        {
            Task.Run(() => func);
        }
    }
}
