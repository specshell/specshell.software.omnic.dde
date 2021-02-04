﻿namespace Specshell.Omnic.Dde.Commands
{
    public class Select : IDdeExecuteCommand
    {
        private readonly string _select;

        public Select(string select = "")
        {
            _select = select;
        }

        public static Select All() => new("All");

        public string Command => string.IsNullOrWhiteSpace(_select) ? "[Select]" : $"[Select {_select}]";
    }
}