﻿using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class LinkTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(Link);

        [TestMethod]
        public void DisplayNameTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UrlTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PropertyNameTest()
        {
            Assert.Inconclusive();
        }
    }
}
