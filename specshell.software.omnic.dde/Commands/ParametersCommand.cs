using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Specshell.Omnic.Dde.Commands
{
    public class ParametersCommand : IDdeExecuteCommand
    {
        private ParametersCommand(string path, bool save)
        {
            var method = save ? "SaveParameters" : "LoadParameters";
            var shortPath = new StringBuilder(255);
            var fullName = new DirectoryInfo(path).FullName;
            var _ = GetShortPathName(fullName, shortPath, shortPath.Capacity);
            Command = $"[{method} {shortPath}]";
        }

        public string Command { get; }

        public static ParametersCommand SaveParameters(string path) => new(path, true);
        public static ParametersCommand LoadParameters(string path) => new(path, false);


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPWStr)] string path,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder shortPath,
            int shortPathLength
        );
    }
}
