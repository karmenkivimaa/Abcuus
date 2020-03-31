using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests: SealedClassTests<UnitData,DefinedEntityView>
    {
        [TestMethod]
        public void MeasureIdTest()
        {
            isNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
