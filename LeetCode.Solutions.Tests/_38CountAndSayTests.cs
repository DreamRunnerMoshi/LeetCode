using LeetCode.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class _38CountAndSayTests
    {
        _38CountAndSay _38CountAndSay;

        public _38CountAndSayTests()
        {
            _38CountAndSay = new _38CountAndSay();
        }

        [Fact]
        public void Positive()
        {
            var actual = _38CountAndSay.CountAndSay(4);
            Assert.Equal("1211",actual);

            actual = _38CountAndSay.CountAndSay(5);
            Assert.Equal("111221", actual);
        }
    }
}
