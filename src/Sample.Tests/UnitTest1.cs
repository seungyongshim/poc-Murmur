using System;
using Murmur;
using Xunit;
using Microsoft.Toolkit.HighPerformance;
using System.Security.Cryptography;
using System.Buffers.Text;
using System.Text.Json;
using FluentAssertions;

namespace Sample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var json = @"{ ""Hello"" : ""World"" }";

            var data = SHA512.HashData(json.AsSpan().AsBytes());

            var encode = BitConverter.ToString(data).Replace("-", string.Empty);

        }
    }
}
