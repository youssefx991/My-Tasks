namespace ITI46.Ecommerce.Core.Base
{
    public abstract class ValueObject
    {
        public override bool Equals(object? obj)
        {
            var propsInfo = typeof(ValueObject).DeclaringType.GetProperties(System.Reflection.BindingFlags.Public);
            var allValues = propsInfo.Select(p => p.GetValue(this)?.ToString());
            var allValuesOfObj = propsInfo.Select(p => p.GetValue(obj)?.ToString());

            return Enumerable.SequenceEqual(allValues, allValuesOfObj);
        }
    }
}
