namespace System
{
    internal static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return string.Concat(thisObj.AsSpan(0, count), "...");
            }
        }
    }
}
