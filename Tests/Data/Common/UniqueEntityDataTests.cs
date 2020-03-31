using Abc.Data.Common;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common
{

    [TestClass]
    public class UniqueEntityDataTests : AbstractClassTests<UniqueView, PeriodData>
    {
        private class testClass : UniqueView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }
        [TestMethod]
        public void IdTest()
        {
            isNullableProperty(() => obj.Id, x => obj.Id = x);
        }
    }

}