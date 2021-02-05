using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Specshell.Omnic.Dde
{
    public static class Extensions
    {
        public static string ToFullPath(this string path) => new FileInfo(path).FullName;

        public static string ToShortPath(this string path)
        {
            try
            {
                var fileName = Path.GetFileName(path);
                var directoryName = Path.GetDirectoryName(path) ?? "";
                var sz = GetShortPathName(directoryName, null!, 0);
                if (sz == 0)
                    throw new Win32Exception();
                var sb = new StringBuilder(sz + 1);
                sz = GetShortPathName(path, sb, sb.Capacity);
                if (sz == 0)
                    throw new Win32Exception();
                return $"{sb}\\{fileName}";
            }
            catch
            {
                return path;
            }
        }

        public static string DoubleDoubleQuote(this string str) => str.Contains(' ') ? $"\"\"{str}\"\"" : str;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPWStr)] string path,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder shortPath,
            int shortPathLength
        );
    }
}
