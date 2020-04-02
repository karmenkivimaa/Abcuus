using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Abc.Tests
{
    public static class TestHtml
    {
        public static void Strings(IReadOnlyList<string> expected, IReadOnlyList<object> actual)
        {
            Assert.IsInstanceOfType(actual, typeof(List<object>));
            Assert.AreEqual(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count; i++)
            {
                var a = actual[i].ToString();
                var e = expected[i];
                Assert.IsTrue(actual[i].ToString().Contains(expected[i]), $"{e} != {a}");
            }
        }
    }
}
