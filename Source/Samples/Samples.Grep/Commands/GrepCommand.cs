﻿using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Samples.Grep.Args;

namespace Samples.Grep.Commands
{
    public class GrepCommand
    {
        public string Execute(GrepArgs args)
        {
            var buffer = new StringBuilder();
            foreach (var line in File.ReadAllLines(args.FileName))
            {
                if (Regex.IsMatch(line, args.Regex))
                {
                    buffer.AppendLine(line);
                }
            }
            return buffer.ToString().Substring(0, buffer.Length - 1);
        }
    }
}
