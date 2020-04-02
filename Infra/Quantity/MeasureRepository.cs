using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Infra.Quantity
{
    public class MeasureRepository: UniqueEntityRepository<Measure, MeasureData>, IMeasuresRepository {

        public MeasureRepository(QuantityDbContext c) : base(c, c.Measures) { }

        protected internal override Measure ToDomainObject(MeasureData d) => new Measure(d);
    }
}
