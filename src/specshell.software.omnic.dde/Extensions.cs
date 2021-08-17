using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Specshell.Omnic.Dde
{
    public static class Extensions
    {
        public static string DoubleQuote(this string str) => str.Contains(' ') ? $"\"{str}\"" : str;

        public static string ToFullPath(this string path) => Path.GetFullPath(path);

        public static string ToShortPath(this string path)
        {
            var sz = GetShortPathName(path, null!, 0);
            if (sz == 0)
                throw new Win32Exception();
            var sb = new StringBuilder(sz + 1);
            sz = GetShortPathName(path, sb, sb.Capacity);
            if (sz == 0)
                throw new Win32Exception();
            return sb.ToString();
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPWStr)] string path,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder shortPath,
            int shortPathLength
        );
    }
}
