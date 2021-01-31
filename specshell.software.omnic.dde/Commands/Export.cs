﻿namespace Specshell.Omnic.Dde.Commands
{
    public class Export : IDdeCommand
    {
        private readonly string _path;

        public Export(string path = "")
        {
            _path = path;
        }

        public string Command => string.IsNullOrWhiteSpace(_path) ? "[Export]" : $"[Export {_path}]";

        public string Data { get; } = string.Empty;

        public CommandType Type => CommandType.Execute;
    }
}