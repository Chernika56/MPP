using FakerLab.Generators.NumericGenerators.Integers;

namespace FakerLab.Generators.NumericGenerators.Floats
{
    public class GeneratorDecimal : IGenerator<decimal>
    {
        public decimal GetValue()
        {
            var intGenerator = new GeneratorInt();

            int lo = intGenerator.GetValue();
            int mid = intGenerator.GetValue();
            int hi = intGenerator.GetValue();
            byte scale = (byte)(intGenerator.GetValue() % 29);

            return new decimal(lo, mid, hi, false, scale);
        }
    }
}
