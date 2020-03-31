using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abc.Facade.Quantity;

namespace Abc.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitViewTests : SealedClassTests<UnitView, DefinedView>
    {
        [TestMethod] public void MeasureIdTest()
        {
            isNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
