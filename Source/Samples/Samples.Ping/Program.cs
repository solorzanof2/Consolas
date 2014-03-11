﻿using Consolas.Core;
using Samples.Ping.Models;
using SimpleInjector;

namespace Samples.Ping
{
    public class Program : Consolas.Core.ConsoleApp
    {
        public static void Main(string[] args)
        {
            Match(args);
        }

        public override void Configure(Container container)
        {
            container.Register<IConsole, SystemConsole>();
            container.Register<IThreadService, ThreadService>();
        }
    }
}