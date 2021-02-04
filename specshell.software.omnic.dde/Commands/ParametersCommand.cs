using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Specshell.Omnic.Dde.Commands
{
    public class ParametersCommand : IDdeExecuteCommand
    {
        private readonly string _path;
        private readonly bool _save;

        private ParametersCommand(string path, bool save)
        {
            _path = path;
            _save = save;
        }

        public static ParametersCommand SaveParameters(string path) => new(path, true);
        public static ParametersCommand LoadParameters(string path) => new(path, false);

        public string Command
        {
            get
            {
                var method = _save ? "SaveParameters" : "LoadParameters";
                var shortPath = new StringBuilder(255);
                var fullName = new DirectoryInfo(_path).FullName;
                var _ = GetShortPathName(fullName, shortPath, shortPath.Capacity);
                return $"[{method} {shortPath}]";
            }
        }


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPWStr)] string path,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder shortPath,
            int shortPathLength
        );
    }
}