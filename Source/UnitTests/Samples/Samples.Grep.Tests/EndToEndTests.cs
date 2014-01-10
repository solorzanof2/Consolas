﻿using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace Samples.Grep.Tests
{
    [TestFixture]
    public class EndToEndTests
    {
        private StringBuilder _consoleOut;
        private TextWriter _outWriter;

        [SetUp]
        public void Setup()
        {
            _outWriter = Console.Out;
            _consoleOut = new StringBuilder();
            Console.SetOut(new StringWriter(_consoleOut));
        }

        [TearDown]
        public void TearDown()
        {
            Console.SetOut(_outWriter);
        }

        [Test]
        public void Grep()
        {
            Program.Main(new[] {"foo", "doc.txt"});
            StringAssert.Contains("foo bar baz", _consoleOut.ToString());
        }

        [Test]
        public void Version()
        {
            Program.Main(new []{ "-version"});
            StringAssert.Contains("2.4.2", _consoleOut.ToString());
        }
    }
}
